using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static KalyanamMatrimony.Models.CustomEnums;

namespace KalyanamMatrimony.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mark",
                    Department = Dept.IT,
                    Email = "mark@pragimtech.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "John",
                    Department = Dept.HR,
                    Email = "john@pragimtech.com"
                }
            );

            //modelBuilder.Entity<IdentityRole>().HasData(
            //    new IdentityRole
            //    {
            //        Id = "1",
            //        Name = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.SuperAdmin)
            //    },
            //    new IdentityRole
            //    {
            //        Id = "2",
            //        Name = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Admin)
            //    },
            //    new IdentityRole
            //    {
            //        Id = "3",
            //        Name = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Profile)
            //    }
            //);
        }
    }
}
