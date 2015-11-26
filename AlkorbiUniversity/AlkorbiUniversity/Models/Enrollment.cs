using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlkorbiUniversity.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Student Number")]
        public int StudentNumber { get; set; }

        [Display(Name = "Enrollment Status")]
        public string EnrollmentStatus { get; set; }

        [Display(Name = "Administration Comments")]
        public string AdministrationComments { get; set; }


    }
}