﻿using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }

        public string Date { get; set; }
        [Required]
/*        [ValidTime]*/
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; } 
        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<ApplicationUser> User { get; set; }

        public string Name { get; set; }    

        public DateTime GetDateTime() 
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}