using System;
using System.Collections.Generic;
using System.Text;
using my_movies.Data;

namespace my_movies.Repository.Interfaces
{
    public interface IUserRepository
    {
        User GetUserByUsername(User userModel);
        void Add(User user);
    }
}
