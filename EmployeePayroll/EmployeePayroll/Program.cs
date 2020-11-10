using System;
using System.Globalization;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Service");
            EmployeeRepo employeeRepo = new EmployeeRepo();

            bool cont = true;

            while (cont)
            {
                Console.WriteLine("Choose \n1. View all records \n2. Add record \n3. Update salary \n4. Get employees joined within a date range");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        employeeRepo.GetAllEmployee();
                        break;
                    case 2:
                        Console.WriteLine("Enter Name ,Department, Phone no, Address, Gender, BasicPay, Deduction, Taxable Pay, Tax, NetPay ");
                        
                        Console.WriteLine("Enter Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter department");
                        string department = Console.ReadLine();

                        Console.WriteLine("Enter phoneNo");
                        string phoneNo = Console.ReadLine();

                        Console.WriteLine("Enter address");
                        string address = Console.ReadLine();

                        Console.WriteLine("Enter gender");
                        char gender = Convert.ToChar(Console.ReadLine());

                        Console.WriteLine("Enter basic pay");
                        double basicPay = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter deductions");
                        double deductions = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter taxable pay");
                        double taxablePay = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter tax");
                        double tax = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter netpay");
                        double netPay = Convert.ToDouble(Console.ReadLine());

                        EmployeeModel employee = new EmployeeModel();
                        employee.EmployeeFirstName = name;
                        employee.Department = department;
                        employee.PhoneNumber = phoneNo;
                        employee.Address = address;
                        employee.Gender = gender;
                        employee.StartDate = DateTime.Today;
                        employee.BasicPay = Convert.ToDecimal(basicPay);
                        employee.Deductions = Convert.ToDecimal(deductions);
                        employee.TaxablePay = Convert.ToDecimal(taxablePay);
                        employee.Tax = Convert.ToDecimal(tax);
                        employee.NetPay = Convert.ToDecimal(netPay);

                        employeeRepo.AddEmployee(employee);

                        Console.WriteLine("Records added successfully");
                        break;
                    case 3:
                        employeeRepo.UpdateSalary("Bill", 150000);
                        Console.WriteLine("Salary updated");
                        break;

                    case 4:
                        Console.WriteLine("Enter Dates");
                        string[] dates = Console.ReadLine().Split(",");

                        employeeRepo.GetEmployeesGivenDateRange(Convert.ToDateTime(dates[0]), Convert.ToDateTime(dates[1]));
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            }
        }
    }
}
