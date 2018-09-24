﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace stackoverflow.Models
{
    public class UserRegisterDTO
    {
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$",
            ErrorMessage = "Password must has minimum 8 characters, at least one uppercase letter, one lowercase letter and one number.")]
        public string Password { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$",
            ErrorMessage = "Password must has minimum 8 characters, at least one uppercase letter, one lowercase letter and one number.")]
        public string PasswordConfirm { get; set; }
    }
}