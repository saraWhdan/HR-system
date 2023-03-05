using System;
using System.Collections.Generic;

namespace HRSystem
{
    public class FullTimeEmployee: Employee, IEmployeeRepository<FullTimeEmployee>
    {
        // Data source
        static List<FullTimeEmployee> employees = new List<FullTimeEmployee>
        {
           new FullTimeEmployee{Id=1, Name="Ahmed Emam", Department = Departments.Management, Salary = 5000M},
            new FullTimeEmployee{Id=2, Name="Sara Ahmed", Department = Departments.HR, Salary = 3000M},
            new FullTimeEmployee{Id=3, Name="Hazem Samy", Department = Departments.Development, Salary = 4000M}
        };

        public FullTimeEmployee()
        {
            WorkingModel = WorkingModels.fullTime;
        }

        // Get all employees from the data source
        public List<FullTimeEmployee> GetAll()
        {
            return employees;
        }

        // Get a specific employee by Id
        public FullTimeEmployee GetById(int id)
        {
            foreach (var emp in employees)
            {
                if (emp.Id == id)
                    return emp;
            }
            return null;
        }


      // Add a new employee
        public void Add(FullTimeEmployee model)
        {
            employees.Add(model);
            Console.WriteLine("A new full time employee has been added");
        }   
        
        // Update an exisiting employee
        public void Update(FullTimeEmployee newEmp, int id)
        {
            foreach (var emp in employees)
            {
                if (emp.Id == id)
                {
                    emp.Name = newEmp.Name;
                    emp.Salary = newEmp.Salary;
                    emp.Department = newEmp.Department;
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
            get { return salary; }
            set { if (value > 0) salary = value * (1 - tax); }
        }

        const decimal tax = 0.14M;
    }
}
