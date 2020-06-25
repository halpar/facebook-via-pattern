using Facebook.Common.DTO;
using FacebookApp.Business;
using FacebookApp.Business.Contracts;
using FacebookApp.Data.Models;
using FacebookApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FacebookApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _UoW;

        public UserService(IUnitOfWork unitOfWork)
        {
            this._UoW = unitOfWork;
        }

        public async Task CreateUser(UserDTO newUser)
        {
            //DTO to entity
            User user = new User();
            user.Email = newUser.Email;
            user.BirthDate = newUser.BirthDate;
            user.Password = newUser.Password;
            user.Name = newUser.Name;
            user.Surname = newUser.Surname;
            user.Phone = newUser.Phone;
            user.Gender = newUser.Gender;
            _UoW.UserRepository.Add(user);

            await _UoW.Commit();
        }

        public async Task DeleteUser(UserDTO userDTO)
        {
            var user = _UoW.UserRepository.GetById(userDTO.UserId);

            _UoW.UserRepository.Delete(user);
            await _UoW.Commit();
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            //Entity to dto

           var users = _UoW.UserRepository.GetAll();

           List<UserDTO> userDtoList = new List<UserDTO>();

            foreach (User user in users)
            {
                UserDTO userDTO = new UserDTO();

                userDTO.UserId = user.UserId;
                userDTO.Name = user.Name;
                userDTO.Surname = user.Surname;
                userDTO.Email = user.Email;
                userDTO.Phone = user.Phone;
                userDTO.BirthDate = user.BirthDate;
                userDTO.Password = user.Password;
                userDTO.PersonalInformation = user.PersonalInformation;
                userDTO.Location = user.Location;
                userDTO.ProfileImage = user.ProfileImage;
                userDTO.BannerImage = user.BannerImage;

                userDtoList.Add(userDTO);
            }
            return userDtoList;
        }

        public UserDTO GetUserByEmail(string email)
        {
            var user = _UoW.UserRepository.GetUserByEmail(email);
            
            UserDTO userDTO = new UserDTO();
            userDTO.UserId = user.UserId;
            userDTO.Name = user.Name;
            userDTO.Surname = user.Surname;
            userDTO.Email = user.Email;
            userDTO.Phone = user.Phone;
            userDTO.BirthDate = user.BirthDate;
            userDTO.Password = user.Password;
            userDTO.PersonalInformation = user.PersonalInformation;
            userDTO.Location = user.Location;
            userDTO.ProfileImage = user.ProfileImage;
            userDTO.BannerImage = user.BannerImage;

            return userDTO;
        }

        public UserDTO GetUserById(int userId)
        {
            var user =  _UoW.UserRepository.GetById(userId);

            UserDTO userDTO = new UserDTO();
            userDTO.UserId = user.UserId;
            userDTO.Name = user.Name;
            userDTO.Surname = user.Surname;
            userDTO.Email = user.Email;
            userDTO.Phone = user.Phone;
            userDTO.BirthDate = user.BirthDate;
            userDTO.Password = user.Password;
            userDTO.PersonalInformation = user.PersonalInformation;
            userDTO.Location = user.Location;
            userDTO.ProfileImage = user.ProfileImage;
            userDTO.BannerImage = user.BannerImage;

            return userDTO;
        }

        public bool isUserExists(string email)
        {
            return _UoW.UserRepository.isUserExists(email);
        }

        public async Task UpdateUser(UserDTO userToBeUpdated , UserDTO userDTO)
        {
            var user = _UoW.UserRepository.GetById(userToBeUpdated.UserId);

            user.UserId = userDTO.UserId;
            user.Name = userDTO.Name;
            user.Surname = userDTO.Surname;
            user.Email = userDTO.Email;
            user.Phone = userDTO.Phone;
            user.BirthDate = userDTO.BirthDate;
            user.Password = userDTO.Password;
            user.PersonalInformation = userDTO.PersonalInformation;
            user.Location = userDTO.Location;
            user.ProfileImage = userDTO.ProfileImage;
            user.BannerImage = userDTO.BannerImage;
            _UoW.UserRepository.Update(user);

            await _UoW.Commit();
        }

    }
}
