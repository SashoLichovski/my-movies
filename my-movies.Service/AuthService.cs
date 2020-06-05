using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using my_movies.Data;
using my_movies.Repository.Interfaces;
using my_movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace my_movies.Service
{
    public class AuthService : IAuthService
    {
        public IUserRepository UserRepo { get; }
        public AuthService(IUserRepository userRepo)
        {
            UserRepo = userRepo;
        }

        public async Task<bool> SignInAsync(User user, HttpContext httpContext)
        {
            var iUser = UserRepo.GetUserByUsername(user);
            if (iUser != null && iUser.Password == user.Password)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Username),
                    new Claim(ClaimTypes.Name, user.Username)
                };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                await httpContext.SignInAsync(principal);

                return true;
            }
            return false;
        }

        public async Task SignOutAsync(HttpContext httpContext)
        {
            await httpContext.SignOutAsync();
        }

        public bool SignUp(User user)
        {
            var newUser = UserRepo.GetUserByUsername(user);
            if (newUser == null)
            {
                UserRepo.Add(user);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
