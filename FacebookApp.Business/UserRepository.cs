using FacebookApp.Business.Contracts;
using FacebookApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp.Business
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly FacebookAppDbContext _DbContext;
        public UserRepository(FacebookAppDbContext context) :base(context)
        {
            _DbContext = context;
        }

        public bool isUserExists(string email)
        {
            return this._DbContext.Users.Any(u => u.Email == email);
        }

        public IEnumerable<User> GetUserWithFriends(int userId)
        {
            return _DbContext.Users
               .Include(u => u.Friends)
               .Where(u => u.UserId == userId);
        }

        public IEnumerable<User> GetUserWithGender(int userId)
        {
            return _DbContext.Users
               .Include(u => u.Gender)
               .Where(u => u.UserId == userId);
        }

        public IEnumerable<User> GetUserWithPosts(int userId)
        {
            return _DbContext.Users
               .Include(u => u.Posts)
               .Where(u => u.UserId == userId);
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            return this._DbContext.Users.SingleOrDefault(u => u.Email == email && u.Password == password);
        }

        public User GetUserByEmail(string email)
        {
            return this._DbContext.Users.SingleOrDefault(u => u.Email == email);
        }
    }
}
