using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        protected readonly UserManager<AppUser> _userManager;
        protected readonly SignInManager<AppUser> _signInManager;
        protected readonly RoleManager<AppRole> _roleManager;
        protected readonly IHttpContextAccessor _httpContextAccessor;
        protected readonly IEMailService _eMailService;

        public AppUserService(IGenericRepository<AppUser> repository, IMapper mapper, UserManager<AppUser> userManager, IEMailService eMailService, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, IHttpContextAccessor httpContextAccessor) : base(repository, mapper)
        {
            _userManager = userManager;
            _eMailService = eMailService;
            _userManager.RegisterTokenProvider(TokenOptions.DefaultProvider, new EmailTokenProvider<AppUser>());
            _signInManager = signInManager;
            _roleManager = roleManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Result<AppUserSaveVM>> RegisterBasicUserAsync(AppUserSaveVM viewModel, string origin)
        {
            bool isUserNameExist = await _userManager.FindByNameAsync(viewModel.UserName) == null ? false : true;
            if (isUserNameExist)
                return Result<AppUserSaveVM>.Fail($"{viewModel.UserName} already exist");

            bool isMailExist = await _userManager.FindByEmailAsync(viewModel.Email) == null ? false : true;
            if (isMailExist)
                return Result<AppUserSaveVM>.Fail($"an account already registered with {viewModel.Email}");

            AppUser appUser = _mapper.Map<AppUser>(viewModel);

            IdentityResult result = await _userManager.CreateAsync(appUser, viewModel.Password);
            if (result.Succeeded)
            {
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
            return Result<AppUserSaveVM>.Fail($"an error occured");

        }

        //Private Method For Creating Email Uri
        private async Task<string> GenerateVerificationEmailUri(AppUser user, string origin)
        {
            string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));

            string route = "Account/ConfirmEmail";
            Uri uri = new Uri(string.Concat($"{origin}/", route));
            string verificationUri = QueryHelpers.AddQueryString(uri.ToString(), "userId", user.Id.ToString());
            verificationUri = QueryHelpers.AddQueryString(verificationUri, "token", token);

            //return verificationUri;
            return $"<a href={verificationUri}>Verification Link</a>";
        }


        public async Task<string> ConfirmEmailAsync(string userId, string token)
        {
            AppUser? user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return "No Accounts registered with this user";

            token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token));
            IdentityResult result = await _userManager.ConfirmEmailAsync(user, token);

            if (!result.Succeeded)
                return $"An error occurred while confirming {user.Email}.";


            return $"Account confirmed for {user.Email} - ({user.UserName}). You can now use the app as a Member";
        }

        public async Task<Result<AppUserSaveVM>> LoginAsync(AppUserLoginVM vm)
        {
            AppUser? user = await _userManager.FindByEmailAsync(vm.Email);
            if (user == null)
                return Result<AppUserSaveVM>.Fail("wrong e-mail");

            if (!user.EmailConfirmed)
                return Result<AppUserSaveVM>.Fail("e-mail is not verified");

            SignInResult result = await _signInManager.PasswordSignInAsync(user.UserName, vm.Password, vm.RememberMe, lockoutOnFailure: false);

            if (!result.Succeeded)
                return Result<AppUserSaveVM>.Fail("wrong password");

            AppUserSaveVM appUserSaveVM = _mapper.Map<AppUserSaveVM>(user);
            return Result<AppUserSaveVM>.Success(appUserSaveVM);
        }

        //create sign out method
        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<Result<AppUserVM>> GetUserAsync()
        {
            HttpContext? httpContext = _httpContextAccessor.HttpContext;
            if (httpContext != null)
            {
                AppUser? curUser = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
                AppUserVM appUserVM = _mapper.Map<AppUserVM>(curUser);
                return Result<AppUserVM>.Success(appUserVM);
            }
            return Result<AppUserVM>.Fail("user not found");
        }
    }
}

