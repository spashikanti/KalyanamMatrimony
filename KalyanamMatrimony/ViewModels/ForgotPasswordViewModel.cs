﻿using System.ComponentModel.DataAnnotations;

namespace KalyanamMatrimony.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
