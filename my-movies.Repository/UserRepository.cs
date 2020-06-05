using my_movies.Data;
using my_movies.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace my_movies.Repository
{
    public class UserRepository : IUserRepository
    {
        public MyMoviesContext Context { get; }
        public UserRepository(MyMoviesContext context)
        {
            Context = context;
        }

        public User GetUserByUsername(User userModel)
        {
            var user = Context.Users.FirstOrDefault(x => x.Username == userModel.Username);
            return user;
        }

        public void Add(User user)
        {
            Context.Users.Add(user);
            Context.SaveChanges();
        }
    }
}
