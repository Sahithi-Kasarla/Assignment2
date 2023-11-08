using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int id=12;
            string EmployeeName="sam";
            char EmployeeGender='F';
            double EmployeeSalary=98000;
            DateTime Doj;

           // Console.WriteLine("id");
            id = int.Parse(Console.ReadLine());
            // Console.WriteLine("EmployeeName");
            EmployeeName = Console.ReadLine();
           // Console.WriteLine("EmployeeGender");
            EmployeeGender = char.Parse(Console.ReadLine());
           // Console.WriteLine("EmployeeSalary");
            EmployeeSalary = double.Parse(Console.ReadLine());
           // Console.WriteLine("Doj");
             Doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("id \t+ employeeName \t + EmployeeGender \t + EmployeeSalary \t+ doj \t");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(id +"\t"+ EmployeeName +"\t" + EmployeeGender +"\t"+ EmployeeSalary +"\t"+ Doj);
            if(EmployeeSalary>90000)
            {
                Console.WriteLine("you have to pay 30% tax");
            }
            else
            {
                Console.WriteLine("you have to pay 15% tax");
            }
            Console.ReadKey();*/
            Console.WriteLine("Enter Employee Details:");

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Employee Name:");
            string name = Console.ReadLine();

            Console.Write("Employee Gender: ");
            char gender = char.Parse(Console.ReadLine());

            Console.Write("Employee Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Date of Joining: ");
            DateTime doj = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("ID\tEmployee Name\tEmployee Gender\tEmployee Salary\tDOJ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"{id}\t{name}\t\t{gender}\t\t\t{salary}\t{doj:dd/MM/yyyy}");

            double taxRate = salary > 90000 ? 0.30 : 0.15;
            double taxAmount = salary * taxRate;

            Console.WriteLine();
            Console.WriteLine("You have to pay: " + taxAmount.ToString());

            Console.ReadKey();
        }
    }
}
