using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookApp.Data.Models
{
    public class User
    {

        [Key]
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string BirthDate { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Gender { get; set; }

        public string PersonalInformation { get; set; }

        public string Location { get; set; }

        public string ProfileImage { get; set; }

        public string BannerImage { get; set; }

        public DateTime RegistrationDate { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Friend> Friends { get; set; }

    }
}
