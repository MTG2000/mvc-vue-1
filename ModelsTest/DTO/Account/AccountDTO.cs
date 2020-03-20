using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelsTest.DTO
{
    public class AccountDTO 
    {
        [Required(ErrorMessage = "Please enter the user's email")]
        [EmailAddress(ErrorMessage = "The Email Address is not valid")]
        [StringLength(50, ErrorMessage = "The First Name must be less than {1} characters.")]
        [Display(Name = "Your Email:")]
        public string Email { get; set; } 

        [Display(Name = "Your Work:")]
        public string Work { get; set; }
    }
}