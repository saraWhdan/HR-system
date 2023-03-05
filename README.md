

# HR System
This is a C# console application that simulates a human resources system. It defines two types of employees: full-time and part-time. Both types of employees inherit from a base class Employee. The application also defines two interfaces: IEmployeeRepository and IEmployeeRepository<T>. IEmployeeRepository defines the basic CRUD operations, while IEmployeeRepository<T> extends IEmployeeRepository and is used to define specific repositories for each type of employee.

## Employee class
The Employee class defines the basic properties and fields that are common to both types of employees, such as id, name, department, workingModel, and salary. Salary is an abstract property that is implemented differently in each type of employee. Employee is an abstract class and cannot be instantiated.

## FullTimeEmployee class
The FullTimeEmployee class represents a full-time employee. It inherits from the Employee class and implements IEmployeeRepository<FullTimeEmployee>. It defines a data source that contains a list of full-time employees, and it implements the CRUD operations for full-time employees.

Full-time employees are taxed at a rate of 14%, so their salary is calculated by subtracting 14% from the specified salary.

## PartTimeEmployee class
The PartTimeEmployee class represents a part-time employee. It also inherits from the Employee class and implements IEmployeeRepository<PartTimeEmployee>. It defines a data source that contains a list of part-time employees, and it implements the CRUD operations for part-time employees.

Part-time employees are paid an hourly rate, and their salary is calculated by multiplying the hourly rate by the number of hours worked. Part-time employees' salary is not taxed.

## IEmployeeRepository<T> interface
The IEmployeeRepository<T> interface extends IEmployeeRepository and is used to define specific repositories for each type of employee. It is implemented by both the FullTimeEmployee and PartTimeEmployee classes.

## Program class
The Program class contains the Main method, which is the entry point for the application. It creates a FullTimeEmployee object, adds a new employee, and prints out all the full-time employees. It then creates a PartTimeEmployee object, deletes an existing employee, and prints out all the part-time employees.



