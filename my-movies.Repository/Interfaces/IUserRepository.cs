using System;
using System.Collections.Generic;
using System.Text;
using my_movies.Data;

namespace my_movies.Repository.Interfaces
{
    public interface IUserRepository
    {
        User GetUserByUsername(string username);
        void Add(User user);
        User GetUserById(int id);
        void UpdateUser(User user);
        List<User> GetAll();
        void RemoveUser(User user);
    }
}
