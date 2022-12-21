using System;
using System.Collections.Generic;
using System.Text;

namespace Project_2
{
    internal class Employee : Human
    {
      

        public double Salary = 0;
        public string Position = "";

        public Employee[] GetEmployees(int num)
        {
            Employee[] employees = new Employee[num];

            for (int i = 0; i < employees.Length; i++) // Burani komente atib program.cs deki foru isledirem exception verir.
            {
                Console.WriteLine($"{i + 1}. Employee'nin adini daxil edin!");
                employees[i].FullName = Console.ReadLine();

                Console.WriteLine($"{i + 1}. yasini daxil edin!");
                employees[i].Age = double.Parse(Console.ReadLine());

                Console.WriteLine($"{i + 1}. maasini daxil edin!");
                employees[i].Salary = double.Parse(Console.ReadLine());

                Console.WriteLine($"{i + 1}. vezifesini daxil edin!");
                employees[i].Position = Console.ReadLine();
            }
            return employees;

        }
    }
}
//Employee:Human - Salary
// - Position
//Layihə run olduqda bizdən say daxil etməyimizi istəyir
//Həmin say uzunluqda bir Employee array yaradirsınız
//Həmin sayda employee datasının dəyərlərini  console-dan götürüb, employee obyektləri yaradıb array-ə yerləşdirin



