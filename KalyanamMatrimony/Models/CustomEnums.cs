﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.Models
{
    public static class CustomEnums
    {
        public enum Dept
        {
            HR,
            IT,
            Admin
        }

        public enum CustomRole
        {
            SuperAdmin = 1,
            Admin = 2,
            Profile = 3
        }

        public enum ProfileGender
        {
            None = 0,
            Male,
            Female
        }

        public enum ToastType
        {
            Info,
            Warning,
            Error,
            Success
        }
    }
}
