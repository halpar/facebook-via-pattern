using Facebook.Common.DTO;
using FacebookApp.Business.Contracts;
using FacebookApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FacebookApp.Services.Contracts
{
    public interface IUserService 
    {
        IEnumerable<UserDTO> GetAllUsers();
        UserDTO GetUserById(int userId);
        Task CreateUser(UserDTO newUser);
        UserDTO GetUserByEmail(string email);
        bool isUserExists(string email);
        Task UpdateUser(UserDTO artistToBeUpdated, UserDTO artist);
        Task DeleteUser(UserDTO user);
    }
}
