using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using my_movies.Helpers;
using my_movies.Service.Interfaces;
using my_movies.ViewModels;


namespace my_movies.Controllers
{
    public class AuthController : Controller
    {
        public IAuthService AuthService { get; }
        public AuthController(IAuthService userService)
        {
            AuthService = userService;
        }

        public IActionResult SignIn()
        {
            var user = new UserModel();
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserModel user)
        {
            if (ModelState.IsValid)
            {
                var converted = ConvertModel.ConvertToUser(user);
                var isValid = await AuthService.SignInAsync(converted, HttpContext);
                if (isValid)
                {
                    return RedirectToAction("HomePage", "Home");
                }
                ModelState.AddModelError(string.Empty, "Inccorect Username or Password");
                return View();
            }
            return View(user);
        }
        public async Task<IActionResult> SignOut()
        {
            await AuthService.SignOutAsync(HttpContext);
            return RedirectToAction("HomePage", "Home");
        }
        public IActionResult Register()
        {
            var newUser = new RegisterUserModel();
            return View(newUser);
        }
        [HttpPost]
        public IActionResult Register(RegisterUserModel registerUser)
        {
            if (ModelState.IsValid)
            {
                var user = ConvertModel.ConvertToUser(registerUser);
                var state = AuthService.SignUp(user);
                if (state)
                {
                    return RedirectToAction("HomePage", "Home");
                }
                else
                {
                    return View(registerUser);
                }
                
            }
            return View(registerUser);
        }
    }
}