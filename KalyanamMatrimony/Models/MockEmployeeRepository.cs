using System;
using System.Collections.Generic;
using System.Linq;
using static KalyanamMatrimony.Models.CustomEnums;

namespace KalyanamMatrimony.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id=1, Name="First Employee", Email="first@gmail.com", Department=Dept.HR },
                new Employee(){ Id=2, Name="Second Employee", Email="second@gmail.com", Department=Dept.Admin },
                new Employee(){ Id=3, Name="Third Employee", Email="third@gmail.com", Department=Dept.HR }
            };
        }

        public Employee Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            throw new NotImplementedException();
        }
    }
}
