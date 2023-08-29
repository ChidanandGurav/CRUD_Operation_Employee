using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation_Employee
{
    public class Program
    {
        static void Main(string[] args)
        {
            int No = 0;
            EmployeeCrud crud = new EmployeeCrud();

            do
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Employee List");
                Console.WriteLine("2. Get Employee By Id");
                Console.WriteLine("3. Add Employee");
                Console.WriteLine("4. Update Employee");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("Select your option");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        List<Employee> list = crud.GetEmployee();
                        Console.WriteLine("Id\t    Name\t    Department\t    Salary\t");
                        foreach(Employee EM in list)
                        { 
                            Console.WriteLine($"{EM.Id}      {EM.Name}       {EM.Department}       {EM.Salary}");
                        }
                    break;

                    case 2:
                        Console.WriteLine("Enter Employee_Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Employee e = crud.GetEmployeeById(id);
                        Console.WriteLine("Id\t    Name\t    Department\t    Salary\t");
                        Console.WriteLine($"{e.Id}      {e.Name}       {e.Department}       {e.Salary}");
                        break;

                    case 3:
                        Employee e1 = new Employee();
                        Console.WriteLine("Enter Employee_Id");
                        e1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee_Name");
                        e1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Employee_Department");
                        e1.Department = Console.ReadLine();
                        Console.WriteLine("Enter Employee_Salary");
                        e1.Salary = Convert.ToInt32(Console.ReadLine());
                        crud.AddEmployee(e1);
                        Console.WriteLine("Save Employee");
                        break;

                    case 4:
                        Employee e2 = new Employee();
                        Console.WriteLine("Enter Employee_Id");
                        e2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee_Name");
                        e2.Name = Console.ReadLine();
                        Console.WriteLine("Enter Employee_Department");
                        e2.Department = Console.ReadLine();
                        Console.WriteLine("Enter Employee_Salary");
                        e2.Salary = Convert.ToInt32(Console.ReadLine());
                        crud.UpdateEmployee(e2);
                        Console.WriteLine("Update Details");
                        break;


                    case 5:
                        Console.WriteLine("Enter Your EMployee_Id");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteEmployee(id2);
                        Console.WriteLine("Employee Deleted");
                        break;  

                }

                Console.WriteLine("Press 1 for Continue");
                No = Convert.ToInt32(Console.ReadLine());
            }
            while (No == 1);
        }
    }
}
