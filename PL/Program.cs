using System;
using System.Xml.Linq;
using DTO;
using BLL;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i > 0)
            {
                Console.WriteLine("Employee Management System");
                Console.WriteLine("1. List Employees");
                Console.WriteLine("2. Add Employees");
                Console.WriteLine("3. Update Employees");
                Console.WriteLine("4. Delete Employees");
                Console.WriteLine("5. Search Employees");
                Console.WriteLine("6. Manage Departments");
                Console.WriteLine("7. Exit");
                Console.Write("Choose what you want: ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    EmployeeBLL eb = new EmployeeBLL();
                    List<EmployeeDTO> list = eb.GetAll();
                    Console.WriteLine("All Employees: ");
                    int x = 0;
                    foreach(EmployeeDTO e in list) 
                    {
                        Console.WriteLine(e);
                        x++;
                    }
                    if (x == 0)
                    {
                        Console.WriteLine("No Employee");
                    }
                }
                else if (option == 2)
                {
                    EmployeeBLL eb = new EmployeeBLL();
                    Console.Write("Employee's ID: ");
                    string id = Console.ReadLine();
                    Console.Write("Employee's Name: ");
                    string n = Console.ReadLine();
                    Console.Write("Employee's Age: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Employee's Department: ");
                    string d = Console.ReadLine();
                    Console.Write("Employee's Salary: ");
                    float s = float.Parse(Console.ReadLine());
                    Console.Write("Employee's Joining-Date: ");
                    string j = Console.ReadLine();
                    int result = eb.create(id, n, a, d, s, j);
                    if (result == 1) 
                    {
                        Console.WriteLine("Employee Added Successfully");
                    }
                    else if (result == -1)
                    {
                        Console.WriteLine("Sorry, this id already exists");
                    }
                    else if (result == -2)
                    {
                        Console.WriteLine("Sorry, there's no such department");
                    }
                    else if (result == -3)
                    {
                        Console.WriteLine("Sorry, age is not in limit");
                    }
                    else if (result == -4)
                    {
                        Console.WriteLine("Sorry, this name is not valid");
                    }
                }
                else if (option == 3)
                {
                    Console.WriteLine("Update Employee: ");
                    Console.WriteLine("1. Update Salary");
                    Console.WriteLine("2. Transfer Department");
                    Console.Write("Choose what you want: ");
                    int op = int.Parse(Console.ReadLine());
                    EmployeeBLL eb = new EmployeeBLL();
                    if (op == 1)
                    {
                        Console.Write("Enter Id to update: ");
                        string id = Console.ReadLine();
                        Console.Write("Enter updated Salary: ");
                        float s = float.Parse(Console.ReadLine());
                        if (eb.updateS(id, s))
                        {
                            Console.WriteLine("Salary Updated Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, there's no such ID exists");
                        }
                    }
                    else if (op == 2)
                    {
                        Console.Write("Enter Id to update: ");
                        string id = Console.ReadLine();
                        Console.Write("Enter new department: ");
                        string d = Console.ReadLine();
                        if (eb.updateD(id, d) == 1)
                        {
                            Console.WriteLine("Updated Successfully");
                        }
                        else if (eb.updateD(id, d) == -1)
                        {
                            Console.WriteLine("Sorry, there's no such department to transfer you to");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, no such ID exists");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                }
                else if (option == 4)
                {
                    EmployeeBLL eb = new EmployeeBLL();
                    Console.Write("Enter Id to delete: ");
                    string id = Console.ReadLine();
                    if (eb.delete(id))
                    {
                        Console.WriteLine("Deleted Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, there's no such ID exists");
                    }
                }
                else if (option == 5)
                {
                    Console.WriteLine("Search Employee: ");
                    EmployeeBLL eb = new EmployeeBLL();
                    Console.WriteLine("1. By ID");
                    Console.WriteLine("2. By Name");
                    Console.WriteLine("3. By Department");
                    Console.WriteLine("4. By Date Range");
                    Console.Write("Choose what you want: ");
                    int op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        Console.Write("Enter Id: ");
                        string id = Console.ReadLine();
                        EmployeeDTO et = eb.searchId(id);
                        if (et != null)
                        {
                            Console.WriteLine(et);
                        }
                        else
                        {
                            Console.WriteLine("No Employee Exist with this id");
                        }
                    }
                    else if (op == 2)
                    {
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        List<EmployeeDTO> list = eb.searchName(name);
                        Console.WriteLine("All Employees with this name: ");
                        int x = 0;
                        foreach (EmployeeDTO e in list)
                        {
                            Console.WriteLine(e);
                            x++;
                        }
                        if (x == 0)
                        {
                            Console.WriteLine("No Employee");
                        }
                    }
                    else if (op == 3)
                    {
                        Console.Write("Enter Department Name: ");
                        string d = Console.ReadLine();
                        List<EmployeeDTO> list = eb.searchByDepartment(d);
                        Console.WriteLine("All Employees of this department: ");
                        int x = 0;
                        foreach (EmployeeDTO e in list)
                        {
                            Console.WriteLine(e);
                            x++;
                        }
                        if (x == 0)
                        {
                            Console.WriteLine("No Employee");
                        }
                    }
                    else if (op == 4) 
                    {
                        Console.Write("Enter Joining Date: ");
                        string d = Console.ReadLine();
                        List<EmployeeDTO> list = eb.searchDate(d);
                        Console.WriteLine("All Employees: ");
                        int x = 0;
                        foreach (EmployeeDTO e in list)
                        {
                            Console.WriteLine(e);
                            x++;
                        }
                        if (x == 0)
                        {
                            Console.WriteLine("No Employee");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");
                    }

                }
                else if (option == 6)
                {
                    EmployeeBLL eb = new EmployeeBLL();
                    Console.WriteLine("Manage Departments: ");
                    Console.WriteLine("1. Add Department");
                    Console.WriteLine("2. Edit Department");
                    Console.WriteLine("3. Delete Department");
                    Console.Write("Choose what you want: ");
                    int op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        Console.Write("Department's ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Department's Name: ");
                        string n = Console.ReadLine();
                        Console.Write("Department's Description: ");
                        string d = Console.ReadLine();
                        int result = eb.createDept(id, n, d);
                        if (result == 1)
                        {
                            Console.WriteLine("Department Added Successfully");
                        }
                        else if (result == -1)
                        {
                            Console.WriteLine("Sorry, this id already exists");
                        }
                        else if (result == -2)
                        {
                            Console.WriteLine("Sorry, this department already exists");
                        }
                        else if (result == -3)
                        {
                            Console.WriteLine("Sorry, department name is not valid");
                        }
                    }
                    else if (op == 2)
                    {
                        Console.Write("Enter Department Name to update: ");
                        string d = Console.ReadLine();
                        Console.Write("Enter Department's description to update: ");
                        string des = Console.ReadLine();
                        if (eb.editDept(d, des))
                        {
                            Console.WriteLine("Descrition of department is updated Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, there's no such department");
                        }
                    }
                    else if(op == 3)
                    {
                        Console.Write("Enter Department Name to delete: ");
                        string d = Console.ReadLine();
                        if (eb.deleteDept(d))
                        {
                            Console.WriteLine("Deleted Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, there's no such department");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                }
                else if (option == 7)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }


        }


    }
}