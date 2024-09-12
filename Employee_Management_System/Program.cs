using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nEmployee Management System:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. View Employee");
                Console.WriteLine("5. List All Employees");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Enter Position: ");
                        string position = Console.ReadLine();
                        Console.Write("Enter Salary: ");
                        decimal salary = decimal.Parse(Console.ReadLine());
                        manager.AddEmployee(name, age, position, salary);
                        break;

                    case "2":
                        Console.Write("Enter Employee ID to Update: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter New Age: ");
                        int newAge = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Position: ");
                        string newPosition = Console.ReadLine();
                        Console.Write("Enter New Salary: ");
                        decimal newSalary = decimal.Parse(Console.ReadLine());
                        manager.UpdateEmployee(updateId, newName, newAge, newPosition, newSalary);
                        break;

                    case "3":
                        Console.Write("Enter Employee ID to Delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        manager.DeleteEmployee(deleteId);
                        break;

                    case "4":
                        Console.Write("Enter Employee ID to View: ");
                        int viewId = int.Parse(Console.ReadLine());
                        manager.ViewEmployee(viewId);
                        break;

                    case "5":
                        manager.ListAllEmployees();
                        break;

                    case "6":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
