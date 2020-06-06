using my_movies.Data;
using my_movies.Repository.Interfaces;
using my_movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Service
{
    public class UserService : IUserService
    {
        public IUserRepository UserRepo { get; }
        public UserService(IUserRepository userRepo)
        {
            UserRepo = userRepo;
        }
        public User GetCurrentUser(int id)
        {
            return UserRepo.GetUserById(id);
        }
        public bool UpdateUsername(User user, string newUsername)
        {
            var checkUsername = UserRepo.GetUserByUsername(newUsername);
            if (checkUsername == null)
            {
                user.Username = newUsername;
                UserRepo.UpdateUsername(user);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UpdatePassword(User user, string newPassword)
        {
            user.Password = newPassword;
            UserRepo.UpdatePassword(user);
        }

        public List<User> GetAll()
        {
            return UserRepo.GetAll();
        }
        public bool UpdateRole(User user)
        {
            if (user.Role == "user")
            {
                user.Role = "sub-admin";
                UserRepo.UpdateRole(user);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RemoveUser(User user)
        {
            UserRepo.RemoveUser(user);
        }
    }
}
