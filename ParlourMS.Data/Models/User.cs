using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParlourMS.Data.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage ="First name is required.")]
        [MaxLength(20,ErrorMessage ="First Name should be less then 20 charactors.")]
        public string FirstName { get; set; }

        [MaxLength ( 20, ErrorMessage = "Last Name should be less then 20 charactors." )]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}
