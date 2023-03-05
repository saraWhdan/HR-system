using System;
using System.Collections.Generic;

namespace HRSystem
{
    public class PartTimeEmployee: Employee, IEmployeeRepository<PartTimeEmployee>
    {
        // Data source
        static List<PartTimeEmployee> employees = new List<PartTimeEmployee>
        {
            new PartTimeEmployee{Id=1, Name="Ahmed Emam", Department = Departments.Management, Salary = 5000M, Hours = 150, HourlyRate = 100M},
            new PartTimeEmployee{Id=2, Name="Sara Ahmed", Department = Departments.HR, Salary = 3000M, Hours = 50, HourlyRate = 200M},
            new PartTimeEmployee{Id=3, Name="Hazem Samy", Department = Departments.Development, Salary = 4000M, Hours = 480, HourlyRate = 50M}
        };

        public PartTimeEmployee()
        {
            WorkingModel = WorkingModels.partTime;
        }

        // Get all employees from the data source
        public List<PartTimeEmployee> GetAll()
        {
            return employees;
        }

        // Get a specific employee by Id
        public PartTimeEmployee GetById(int id)
        {
            foreach (var emp in employees)
            {
                if (emp.Id == id)
                    return emp;
            }
            return null;
        }

        // Add a new employee
        public void Add(PartTimeEmployee model)
        {
            employees.Add(model);
            Console.WriteLine("A new part time employee has been added");
        }

        // Update an exisiting employee
        public void Update(PartTimeEmployee newEmp, int id)
        {
            foreach (var emp in employees)
            {
                if (emp.Id == id)
                {
                    emp.Name = newEmp.Name;
                    emp.Salary = newEmp.Salary;
                    emp.Department = newEmp.Department;
                    emp.Hours = newEmp.Hours;
                    emp.HourlyRate = newEmp.HourlyRate;
                    Console.WriteLine($"Employee with id {id} has been modified");
                    break;
                }
            }            
        }

        // Delete an existing employee
        public void Delete(int id)
        {
            foreach (var emp in employees)
            {
                if (emp.Id == id)
                {
                    employees.Remove(emp);
                    Console.WriteLine($"Employee with id {id} has been removed");
                    break;
                }                    
            }

        }

        public override decimal Salary
        {
            get { return (decimal)Hours * hourlyRate; }
            set { if (value > 0) salary = value; }
        }        

        double hours;
        decimal hourlyRate;

        public double Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }
    }
}
