using ConsoleApp4.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Controller
{
    internal class UserController: UserService
    {

        public UserService userService;

        
        public UserController()
        {
           
            UserService employeeService = new UserService();
            int a = 166;
        }
        public void GetAll()
        {
           
            var result = UserService.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.id + " " + item.id);
            }


        }
        public void GetAllByAge()
        {
            UserService employeeService = new UserService();
            var employees = employeeService.GetAll();
            var result = employeeService.GetAllById(employees, 1);
            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.surname + "" + item.id);
            }

        }
        public void GetCountByAge()
        {
            Console.WriteLine("add fist age");
            int firstage = int.Parse(Console.ReadLine());

            Console.WriteLine("add fist age");
            int lastage = int.Parse(Console.ReadLine());
            int result = userService.GetCountById(userService.GetAll(), firstid, lastid);
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
