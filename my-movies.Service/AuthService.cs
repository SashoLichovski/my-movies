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
            var iUser = UserRepo.GetUserByUsername(user.Username);
            if (iUser != null && iUser.Password == user.Password)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, iUser.Username),
                    new Claim(ClaimTypes.Name, iUser.Username),
                    new Claim("Id", iUser.Id.ToString())
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
            var newUser = UserRepo.GetUserByUsername(user.Username);
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
