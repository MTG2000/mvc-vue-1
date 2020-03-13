using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SqlTest.Models
{
    public class Student
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CollegeID { get; set; }


        public virtual College College { get; set; }
    }
}