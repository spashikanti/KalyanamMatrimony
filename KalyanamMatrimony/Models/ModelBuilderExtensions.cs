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

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    UserName = "sunil.pashikanti@gmail.com",
                    Email = "sunil.pashikanti@gmail.com",
                    PasswordHash = "AQAAAAEAACcQAAAAEPZ/6w4+04Y/iWjqC9AyZANRUSyhavIYUxDFn4N/VFrWD0a0I4DLkzR64GWgJ8/tXA=="
                }
            );
        }
    }
}
