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
    [Authorized]
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
            ViewBag.header = $"Hi {converted.Username} !";
            return View(converted);
        }
        public IActionResult ChangeUsername(int id)
        {
            ViewBag.header = "Enter your new username";
            var user = UserService.GetCurrentUser(id);
            var converted = ConvertModel.ToChangeUsernameModel(user);
            return View(converted);
        }
        [HttpPost]
        public IActionResult ChangeUsername(ChangeUsernameModel model)
        {
            ViewBag.header = "Enter your new username";
            if (ModelState.IsValid)
            {
                var user = ConvertModel.ConvertToUser(model);
                var status = UserService.UpdateUsername(user, model.Username);
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
            ViewBag.header = "Enter your new password";
            var user = UserService.GetCurrentUser(id);
            var converted = ConvertModel.ToChangePasswordModel(user);
            return View(converted);
        }
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordModel model)
        {
            ViewBag.header = "Enter your new password";
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
        public IActionResult ManageUsers()
        {
            ViewBag.header = "All users";
            var allUsers = UserService.GetAll();
            var convertedUsers = new List<ManageUsersModel>();
            foreach (var user in allUsers)
            {
                var converted = ConvertModel.ToManageUsersModel(user);
                convertedUsers.Add(converted);
            }
            return View(convertedUsers);
        }
        public IActionResult AddSubAdmin(int id)
        {
            var user = UserService.GetCurrentUser(id);
            bool status = UserService.UpdateRole(user);
            if (status)
            {
                return RedirectToAction("ManageUsers");
            }
            return RedirectToAction("ManageUsers");
        }
        public IActionResult DeleteUser(int id)
        {
            var user = UserService.GetCurrentUser(id);
            UserService.RemoveUser(user);
            return RedirectToAction("ManageUsers");
        }
    }
}