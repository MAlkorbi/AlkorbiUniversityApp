using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlkorbiUniversity.Models
{
    public class Student
    {

        public int StudentID { get; set; }


        [Display(Name = "Student Number")]
        public int StudentNumber { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Last name cannot be longer than 20 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "First name cannot be longer than 20 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public string Title { get; set; }

        [Required]
        [Range(1000, 5000, ErrorMessage = "Course number must between 1000 to 5000")]
        [Display(Name = "Course Number")]
        public int CourseNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

    }
}