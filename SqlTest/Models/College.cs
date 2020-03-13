using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SqlTest.Models
{
    public class College
    {
         [DatabaseGenerated(DatabaseGeneratedOption.None)] //this attribute lets you enter the primary key for the course rather than having the database generate it
        public int ID { get; set; }
        public string Name { get; set; }
        public int YearsOfStudy { get; set; }
       
    }
}