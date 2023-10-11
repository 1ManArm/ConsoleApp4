
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пила-струна. Стиль паука.");
            Manager Manager1 = new();
            Accountant Acc1 = new();
            Manager1.FName = "Тестировщиков, Тестировщик Тестировщикович";
            Manager1.WorkDays = 270;
            Manager1.CalculateSalary(270);
            Acc1.CalculateTax(Manager1);
            Manager1.Print();
            DeptHead DeptHead1 = new();
            DeptHead1.FName = "Тестировщиков, Тестировщик Тестировщикович";
            DeptHead1.WorkDays = 244;
            DeptHead1.CalculateSalary(244);
            Acc1.CalculateTax(DeptHead1);
            DeptHead1.Print();
        }

        interface Interface
        {
            static Interface()
            {

            }
            const int a = 10;
            static int b;
            public int c { get; set; }
            public void Ball();
        }
        interface Interface2
        {

        }
        class c1 { }
        class c2 { }
        class c3 : c1, Interface, Interface2
        {
            public int Abc { get; set; }
            public int c { get; set; }
            public void Ball()
            {

            }
        } 
        
    }
}