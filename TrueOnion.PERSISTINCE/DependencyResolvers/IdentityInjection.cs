using Autofac.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using TrueOnion.DOMAIN.Entities.Concrates;
using TrueOnion.PERSISTINCE.Context;

namespace TrueOnion.PERSISTINCE.DependencyResolvers
{
    public static class IdentityInjection
    {
        public static void AddIdentityService(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(
                x =>
                {
                    x.Password.RequireDigit = false;
                    x.Password.RequireLowercase = false;
                    x.Password.RequireUppercase = false;
                    x.Password.RequireNonAlphanumeric = false;
                    x.Password.RequiredLength = 3;
                    x.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                    x.User.RequireUniqueEmail = true;
                    x.SignIn.RequireConfirmedEmail = true;
                })
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
            
            services.ConfigureApplicationCookie(x =>
            {
                x.LoginPath = new PathString("/Account/Login");
                //x.LogoutPath = "/Account/LogOut";
                x.AccessDeniedPath = new PathString("/Account/AccessDenied");
                x.SlidingExpiration = true;
                x.ExpireTimeSpan = System.TimeSpan.FromMinutes(30);
                x.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = "TrueOnionCookie",
                    SameSite = SameSiteMode.Strict,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest // Always
                };
            });
            services.AddAuthentication();

        }
    }
}
