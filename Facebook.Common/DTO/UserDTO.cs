using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.Common.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string BirthDate { get; set; }

        public string Password { get; set; }

        public string PersonalInformation { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string Location { get; set; }

        public string ProfileImage { get; set; }

        public string BannerImage { get; set; }

        public string Gender { get; set; }

        public virtual ICollection<PostDTO> PostDTOs { get; set; }

        public virtual ICollection<FriendDTO> FriendDTOs { get; set; }
    }
}
