using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

        interface ISalary 
        {
            public string FName { get; set; }
        public int WorkDays { get; set; }
        public decimal CalculateSalary(int WorkDays);

        }
        interface ITax
        {
            public decimal CalculateTax(decimal Salary);
        }

       public class Manager : ISalary, Print
        {
            public string FName { get; set; }
            public int WorkDays { get; set; }
            public static decimal Salary;
            
            public decimal CalculateSalary(int WorkDays)
            {
                Salary = WorkDays * 1000;
                return Salary;
            }
            public void Print()
            {
                Console.WriteLine("ФИО: " + FName);
                Console.WriteLine("Кол-во рабочих дней: " + WorkDays);
                Console.WriteLine("Зарплата: " + Salary);
            }

        }
       public class DeptHead : ISalary, Print
        {
            public string FName { get; set; }
            public int WorkDays { get; set;}
            public static decimal Salary;

            public decimal CalculateSalary(int WorkDays)
            {
                Salary = WorkDays * 2500;
                return Salary;
            }
            public void Print()
            {
                Console.WriteLine("ФИО: " + FName);
                Console.WriteLine("Кол-во рабочих дней: " + WorkDays);
                Console.WriteLine("Зарплата: " + Salary);
            }
        }

        class Accountant
        {
            public int WorkDays { get; set; }
            public static decimal Tax;
            public static decimal Salary { get; set; }
            public decimal CalculateTax(ISalary Salary)
            {
                Tax = Salary.CalculateSalary(Salary.WorkDays) * (13 / 100);
                return Tax;
            }

        }
        
        interface Print
        {
            public void Print();
        }

}
