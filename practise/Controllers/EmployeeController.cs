using practise.Employees;
using practise.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise.Controllers
{
    internal class EmployeeController : EmployeeService
    {
        public EmployeeService employeeService;

        //public EmployeeController employeeService;
        public EmployeeController()
        {
            //employeeService = new EmployeeService();
            EmployeeService employeeService = new EmployeeService();
            int a = 166;
        }
        public void GetAll()
        {
            //EmployeeService employeeService = new EmployeeService();
            var result = employeeService.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.age);
            }


        }
        public void GetAllByAge()
        {
            EmployeeService employeeService = new EmployeeService();
            var employees = employeeService.GetAll();
            var result = employeeService.GetAllByAge(employees,30);
            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.surname + "" + item.age);
            }

        }
        public void GetCountByAge()
        {
            Console.WriteLine("add fist age");
            int firstage = int.Parse(Console.ReadLine());

            Console.WriteLine("add fist age");
            int lastage = int.Parse(Console.ReadLine());
            int result = employeeService.GetCountByAge(employeeService.GetAll(),firstage,lastage);
            Console.WriteLine(count);
        }

        public void GetSumOFAges()
        {
            int sumOfAges = employeeService.SummOfAges(employeeService.GetAll());
            Console.WriteLine(sumOfAges);
        }
        public void GetAllByCheckedEmail()
        {
            Console.WriteLine("add your text");
            string str = Console.ReadLine();

            Employee[] employees = employeeService.GetAll();
            Employee[] checkedEmployees = employeeService.GetAllByCheckedEmail(employees, str);
            foreach (var item in checkedEmployees) 
            {
                Console.WriteLine(item.name + " " + item.surname + " " + item.email);
            }
            
        }

    }

}
