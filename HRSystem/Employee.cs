using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HRSystem
{
    public enum WorkingModels { partTime, fullTime };
    public enum Departments { HR, Development, QA, Management}
    public abstract class Employee
    {
        // Fields
        int id;
        string name;
        Departments department;
        protected decimal salary;
        WorkingModels workingModel;        
       
        // Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public abstract Decimal Salary
        {
            get;set;
        }
        public Departments Department
        {
            get { return department; }
            set { department = value; }
        }
        public WorkingModels WorkingModel
        {
            get { return workingModel; }
            set { workingModel = value; }
        }
    }
}
