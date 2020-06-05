using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_movies.Helpers;
using my_movies.Service.Interfaces;
using my_movies.ViewModels;

namespace my_movies.Controllers
{
    public class UserController : Controller
    {
        public IUserService UserService { get; }
        public UserController(IUserService userService)
        {
            UserService = userService;
        }
        public IActionResult UserDetails()
        {
            var currentUserId = int.Parse(User.FindFirst("Id").Value);
            var user = UserService.GetCurrentUser(currentUserId);
            var converted = ConvertModel.ConvertToUserDetailsModel(user);
            return View(converted);
        }
        public IActionResult ChangeUsername(int id)
        {
            var user = UserService.GetCurrentUser(id);
            var converted = ConvertModel.ToChangeUsernameModel(user);
            return View(converted);
        }
        [HttpPost]
        public IActionResult ChangeUsername(ChangeUsernameModel model)
        {
            if (ModelState.IsValid)
            {
                var user = UserService.GetCurrentUser(model.Id);
                var newUsername = model.Username;
                var status = UserService.UpdateUsername(user, newUsername);
                if (status)
                {
                    return RedirectToAction("UserDetails", "User");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, $"Username '{model.Username}' already exists");
                    return View(model);
                }
            }
            return View(model);
        }

        public IActionResult ChangePassword(int id)
        {
            var user = UserService.GetCurrentUser(id);
            var converted = ConvertModel.ToChangePasswordModel(user);
            return View(converted);
        }
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var user = UserService.GetCurrentUser(model.Id);
                if (user.Password != model.OldPassword)
                {
                    ModelState.AddModelError(string.Empty, "Old password does not match");
                    return View(model);
                }
                var newPassword = model.Password;
                UserService.UpdatePassword(user, newPassword);
                return RedirectToAction("UserDetails", "User");
            }
            return View(model);
        }
    }
}