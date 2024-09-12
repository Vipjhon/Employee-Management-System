using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, int age, string position, decimal salary)
        {
            ID = id;
            Name = name;
            Age = age;
            Position = position;
            Salary = salary;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}, Position: {Position}, Salary: ${Salary}");
        }
    }
    class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();
        private int nextId = 1;

        public void AddEmployee(string name, int age, string position, decimal salary)
        {
            Employee newEmployee = new Employee(nextId++, name, age, position, salary);
            employees.Add(newEmployee);
            Console.WriteLine("Employee added successfully.");
        }

        public void UpdateEmployee(int id, string name, int age, string position, decimal salary)
        {
            Employee employee = employees.Find(emp => emp.ID == id);
            if (employee != null)
            {
                employee.Name = name;
                employee.Age = age;
                employee.Position = position;
                employee.Salary = salary;
                Console.WriteLine("Employee details updated successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = employees.Find(emp => emp.ID == id);
            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine("Employee deleted successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public void ViewEmployee(int id)
        {
            Employee employee = employees.Find(emp => emp.ID == id);
            if (employee != null)
            {
                employee.DisplayEmployee();
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public void ListAllEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees in the system.");
            }
            else
            {
                Console.WriteLine("List of Employees:");
                foreach (var employee in employees)
                {
                    employee.DisplayEmployee();
                }
            }
        }
    }
}
