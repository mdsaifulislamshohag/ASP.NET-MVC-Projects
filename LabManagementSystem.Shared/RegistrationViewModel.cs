﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabManagementSystem.Shared
{
    public class RegistrationViewModel
    {
        [Required]
        [Display(Name ="Fullname")]
        public string Fullname { get; set; }

        [Required]
        [Display(Name ="Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }


        [Required]
        [Display(Name = "Password")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*\\d).{8,50}$", ErrorMessage = "Password must be between 8 and 50 digits long and include at least one numeric digit.")]
        public string Password { get; set; }


        [Required]
        [Display(Name = "Confirm Password")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
