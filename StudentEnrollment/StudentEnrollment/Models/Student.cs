﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [RegularExpression("^[a-Z]+$", ErrorMessage = "Only letters [a-Z] are supported")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [RegularExpression("^[a-Z]+$", ErrorMessage = "Only letters [a-Z] are supported")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Registration Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime EnrollmentDate;

        [Display(Name = "Current Course")]
        [Required]
        public Course CurrentCourse { get; set; }

        [Display(Name = "Highest Course Level Completed")]
        public int HighestCourseLevel { get; set; } = 0;

        [Display(Name = "Completed Qualifying Interview")]
        [Required]
        public bool PassedInterview { get; set; } = false;

        [Display(Name = "Placed Professionally")]
        [Required]
        public bool Placed { get; set; } = false;
    }
}
