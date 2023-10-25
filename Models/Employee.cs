using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TemplatedHTMLHelper.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name ="please enter your name")]
        public string Name { get; set; }
        public string   Email { get; set; }
        public bool isOnline { get; set; }
        [Display(Name="Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.Time)]
        public DateTime BirthTime { get; set; }
    }
}