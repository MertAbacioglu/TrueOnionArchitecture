using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using TrueOnion.APPLICATION.DTOs;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Account;
using TrueOnion.APPLICATION.ViewModels.AppUser;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Concrates;
using TrueOnion.DOMAIN.Enums;

namespace TrueOnion.PERSISTINCE.Services
{
    public class AppUserService : GenericService<AppUserSaveVM, AppUserVM, AppUser>, IAppUserService
    {
        protected readonly IEMailService _eMailService;
        protected readonly UserManager<AppUser> _userManager;
        protected readonly SignInManager<AppUser> _signInManager;
        protected readonly RoleManager<AppRole> _roleManager;


        public AppUserService(IGenericRepository<AppUser> repository, IMapper mapper, UserManager<AppUser> userManager, IEMailService eMailService, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager) : base(repository, mapper)
        {
            _userManager = userManager;
            _eMailService = eMailService;
            _userManager.RegisterTokenProvider(TokenOptions.DefaultProvider, new EmailTokenProvider<AppUser>());
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task<Result<AppUserSaveVM>> RegisterBasicUserAsync(AppUserSaveVM viewModel, string origin)
        {
            bool isUserNameExist = await _userManager.FindByNameAsync(viewModel.UserName) == null ? false : true;
            if (isUserNameExist)
                return Result<AppUserSaveVM>.Fail($"{viewModel.UserName} already exist");

            bool isMailExist = await _userManager.FindByEmailAsync(viewModel.Email) == null ? false : true;
            if (isMailExist)
                return Result<AppUserSaveVM>.Fail($"{viewModel.Email} already registered");

            AppUser appUser = _mapper.Map<AppUser>(viewModel);

            await _userManager.CreateAsync(appUser, viewModel.Password);


            await _userManager.AddToRoleAsync(appUser, Role.Member.ToString());
            
            string verificationUri = await GenerateVerificationEmailUri(appUser, origin);


            await _eMailService.SendAsync(new EMailDTO()
            {
                To = viewModel.Email,
                Body = $"click {verificationUri} to complete registration",
                Subject = "registration"
            });
            AppUserSaveVM appUserSaveVM = _mapper.Map<AppUserSaveVM>(appUser);
            return Result<AppUserSaveVM>.Success(appUserSaveVM, $"check your e-mail to confirm your account.");


        }

        //Method private to form the url for the emailVerificationUser page
        private async Task<string> GenerateVerificationEmailUri(AppUser user, string origin)
        {
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));

            string route = "Home/ConfirmEmail";
            Uri uri = new Uri(string.Concat($"{origin}/", route));
            string verificationUri = QueryHelpers.AddQueryString(uri.ToString(), "userId", user.Id.ToString());
            verificationUri = QueryHelpers.AddQueryString(verificationUri, "token", token);

            return verificationUri;
        }

        public async Task<string> ConfirmEmailAsync(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return "No Accounts registered with this user";
            }
            token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token));
            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (!result.Succeeded)
            {
                return $"An error occurred while confirming {user.Email}.";
            }

            return $"Account confirmed for {user.Email}. You can now use the app";
        }

        public async Task<bool> LoginAsync(LoginVM vm)
        {
            AppUser? user = await _userManager.FindByEmailAsync(vm.Email);
            var result = await _signInManager.PasswordSignInAsync(user.UserName, vm.Password, false, lockoutOnFailure: false);
            return true;
        }
    }
}

