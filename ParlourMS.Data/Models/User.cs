using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace ParlourMS.Data.Models
{
    public class User : IdentityUser
    {
        [MaxLength(20,ErrorMessage ="First Name should be less then 20 charactors.")]
        public string FirstName { get; set; }

        [MaxLength ( 20, ErrorMessage = "Last Name should be less then 20 charactors." )]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}
