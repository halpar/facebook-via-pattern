using FacebookApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookApp.Business.Contracts
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUserWithFriends(int userId);
        IEnumerable<User> GetUserWithPosts(int userId);
        IEnumerable<User> GetUserWithGender(int userId);
        bool isUserExists(string email);

        User GetUserByEmailAndPassword(string email, string password);


    }
}
