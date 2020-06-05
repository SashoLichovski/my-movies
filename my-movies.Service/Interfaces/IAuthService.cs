using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using my_movies.Data;

namespace my_movies.Service.Interfaces
{
    public interface IAuthService
    {
        Task<bool> SignInAsync(User user, HttpContext httpContext);
        Task SignOutAsync(HttpContext httpContext);
        bool SignUp(User user);
    }
}
