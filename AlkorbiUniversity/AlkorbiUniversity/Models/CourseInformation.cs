using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlkorbiUniversity.Models
{
    public class CourseInformation
    {
        public int CourseInformationID { get; set; }


        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Credits")]
        public string Credits { get; set; }


        [Display(Name = "Level")]
        public int Level { get; set; }

        [Display(Name = "Aim")]
        public string Aim { get; set; }

        [Display(Name = "Pre Requisites")]
        public string PreRequisites { get; set; }


        [Display(Name = "Starting Date")]
        public DateTime StartingDate { get; set; }

        [Display(Name = "Finishing Date ")]
        public DateTime FinishingDate { get; set; }

    }
}