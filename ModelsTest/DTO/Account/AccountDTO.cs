using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelsTest.DTO
{
    public class AccountDTO 
    {
        public Guid Id { get; set; }
        public string Email { get; set; } 
        public string Work { get; set; }
    }
}