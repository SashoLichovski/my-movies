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

        public User GetUserByUsername(string username)
        {
            var user = Context.Users.FirstOrDefault(x => x.Username == username);
            return user;
        }

        public void Add(User user)
        {
            Context.Users.Add(user);
            Context.SaveChanges();
        }

        public User GetUserById(int id)
        {
            return Context.Users.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateUsername(User user)
        {
            Context.Users.Update(user);
            Context.SaveChanges();
        }

        public void UpdatePassword(User user)
        {
            Context.Users.Update(user);
            Context.SaveChanges();
        }
    }
}
