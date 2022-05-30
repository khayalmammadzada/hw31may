using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi Daxil Edin");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);

            Employee[] employees = new Employee[count];

            for (int i = 0, i< count; i++) 
            {
               
                
                employees[i] = new Employee(count);
                Console.WriteLine($"{i+1}. Emloyee nin adi:");
                employees[i].FullName = Console.ReadLine();
                Console.WriteLine($"{i + 1}. Employee nin yashi:");
                string ageStr = Console.ReadLine();
                employees[i].Age = Convert.ToByte(ageStr);
                Console.WriteLine($"{i+1}. Employeenin Salary-in daxil edin:");
                string salaryStr = Console.ReadLine();
                employees[i].Salary = Convert.ToInt32(salaryStr);
                Console.WriteLine($"{i+1}. Employee nin positionu");
                employees[i].Position = Console.ReadLine();

            }
        }
    }
}
