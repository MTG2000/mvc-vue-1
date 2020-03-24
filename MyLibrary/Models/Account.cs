using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLibrary.Models
{
    public class Account
    {
        public Account()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Work { get; set; }

        
    }
}