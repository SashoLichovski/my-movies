using my_movies.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Service.Interfaces
{
    public interface IUserService
    {
        User GetCurrentUser(int id);
        bool UpdateUsername(User user, string newUsername);
        void UpdatePassword(User user, string newPassword);
    }
}
