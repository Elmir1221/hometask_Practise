using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using practise.Employees;

namespace practise.Service
{
    internal class EmployeeService : Employee
    {
        public Employee[] GetAll()
        {
            Employee employee1 = new()
            {
                id = 1,
                name = "employee",
                surname = "employee",
                address = "employee",
                email = "employee",
                age = 31
            };
            Employee employee2 = new()
            {
                id = 2,
                name = "employee2",
                surname = "employee2",
                address = "employee2",
                email = "employee2",
                age = 21
            };
            Employee employee3 = new()
            {
                id = 3,
                name = "employee3",
                surname = "employee3",
                address = "employee3",
                email = "employee3",
                age = 45
            };
            Employee employee4 = new()
            {
                id = 4,
                name = "employee4",
                surname = "employee4",
                address = "employee4",
                email = "employee4",
                age = 54
            };
            Employee[] employees = { employee1, employee2, employee3, employee4 };
            return employees;



        }

        //public Employee[] GetAllByAge() 
        //{
        // var result = GetAll();
        //    return employees
        //}

        public Employee[] GetAllByAge(Employee employees, int age)
        {

            return employees.Where(m => m.age > age).ToArray();

        }

        public int GetCountByAge(Employee[] employees, int firstage, int lastage)
        {
            return employees.Where(m => m.age > firstage && m.age < lastage).Count();
        }

        public int SummOfAges(Employee[] employees)
        {
            return employees.Sum(m => m.age);
        }
        public Employee[] GetByCheckedEmail(Employee[] employees, string str)
        {
            return employees.Where(m => m.email.StartsWith(str)).ToArray();
        }

    }
}
