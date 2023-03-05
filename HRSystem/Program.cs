using System;
using System.Collections.Generic;

namespace HRSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            
            fullTimeEmployee.Add(new FullTimeEmployee { Id = 4, Name = "Mostafa", Salary = 6000M, Department = Departments.Development});

            var allFullTimeEmps = fullTimeEmployee.GetAll();

            foreach (var emp in allFullTimeEmps)
            {
                Console.WriteLine($"Id: {emp.Id}\tName: {emp.Name}\nDepartment: {emp.Department}\tSalary: {emp.Salary}");
            }

            Console.WriteLine("---------------------------------");

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.Delete(2);

            var allPartTimeEmps = partTimeEmployee.GetAll();
            foreach (var emp in allPartTimeEmps)
            {
                Console.WriteLine($"Id: {emp.Id}\tName: {emp.Name}\tDepartment: {emp.Department}\nSalary: {emp.Salary}\tHours: {emp.Hours}\tRate: {emp.HourlyRate}");
            }
        }
    }
}
