using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BIT286_Application.ViewModels
{
    public class NewAccount
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Enter a Password")]
        public string PasswordOne { get; set; }
        [Required]
        [Display(Name = "Retype your Password")]
        public string PasswordTwo { get; set; }
        [Required]
        [Display(Name = "Are you a teacher?")]
        public bool IsTeacher { get; set; }
        [Display(Name = "Teachers Name")]
        public string TeacherName { get; set; }

    }
}