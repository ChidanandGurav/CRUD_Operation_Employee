using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation_Employee
{
    public class EmployeeCrud
    {
        private List<Employee> employees;

        public EmployeeCrud()
        {
            employees = new List<Employee>()
            {
                new Employee {Id = 101 , Name = "Sandesh" , Department = "HR" , Salary = 25000},
                new Employee {Id = 102 , Name = "Shubham" , Department = "Testing" , Salary = 22000}
            };
        }

        public List<Employee> GetEmployee() // Display List
        {
            return employees;   
        }

        public Employee GetEmployeeById(int Id) // Get Single Employee (Search)
        {
            Employee emp = new Employee();
            foreach(Employee e in employees)
            {
                if(e.Id == Id)
                {
                    emp = e; 
                    break;
                }
            }
            return emp;
        }

        public void AddEmployee(Employee emp) // Add Employee
        {
            employees.Add(emp);
        }

        public void UpdateEmployee(Employee emp) // Modify (Update)
        {
            foreach(Employee item in employees)
            {
                if(item.Id ==emp.Id)
                {
                    item.Name = emp.Name;
                    item.Department = emp.Department;
                    item.Salary = emp.Salary;
                    break;
                }
            }
        }

        public void DeleteEmployee(int Id) // Remove From List
        {
            foreach(Employee item in employees)
            {
                if(item.Id==Id)
                {
                    employees.Remove(item);
                    break;
                }
            }
        }
    }
}
