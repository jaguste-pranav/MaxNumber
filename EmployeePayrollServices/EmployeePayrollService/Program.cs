using System;

namespace EmployeePayrollService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Service!");
            EmployeeRepo repo = new EmployeeRepo();

            repo.GetAllEmployee();

            bool res = repo.AddEmployee(model);
            if (res)
            {
                Console.WriteLine("Employee Added Successfully");
                repo.GetAllEmployee();
            }
            else
            {
                Console.WriteLine("Employee isn't Added");
            }
        }
    }
}