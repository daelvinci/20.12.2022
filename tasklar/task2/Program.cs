using Project_2;
using System;
using System.Dynamic;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siyahinin uzunlugunu daxil edin!");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello World!");
            Employee[] employees = new Employee[num];

            Employee[] employees = Employee.GetEmployees(3); ///MUELLIM bu niye ERROR VERIREE, metodla eliyirem bu error cixir, Metodu komente atib asagidaki for'u ise saliram bu seferde exception verir. fieldleri 0 veya empty string eleedim yene error verir. Null ile baglidi deyesen.

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. Employee'nin adini daxil edin!");
            //    employees[i].FullName = Console.ReadLine();

            //    Console.WriteLine($"{i + 1}. yasini daxil edin!");
            //    employees[i].Age = double.Parse(Console.ReadLine());

            //    Console.WriteLine($"{i + 1}. maasini daxil edin!");
            //    employees[i].Salary = double.Parse(Console.ReadLine());

            //    Console.WriteLine($"{i + 1}. vezifesini daxil edin!");
            //    employees[i].Position = Console.ReadLine();
            //}

            Console.WriteLine("Axtaris etmek isteyirsiiniz mi? Y/N ");
            string yn = Console.ReadLine();
            bool YesOrNo = false;
            do
            {
                Console.WriteLine("Yalniz y ve n daxil edile biler!");

                if (yn == "y" && yn == "n" && yn == "Y" && yn == "N")
                {
                    YesOrNo = true;
                    if (yn == "Y" && yn == "y")
                    {
                        Console.WriteLine("Axtaris deyerini daxil edin!");
                        var axtarisDeyeri = Console.ReadLine();

                        for (int i = 0; i < employees.Length; i++)
                        {
                            if (employees[i].FullName.Contains(axtarisDeyeri))
                            {
                                Console.WriteLine($"Ad: {employees[i].FullName}  Yas: {employees[i].Age} Maas: {employees[i].Salary}  Vezifesi: {employees[i].Position}");

                            }
                        }

                    }
                    else
                        return;

                }

            }
            while (YesOrNo == false);


        }//Əlavə task:
         //Array formalaşdıqdan sonra console pəncərəsində "Axtarıs etmek isteyirsinizmi? y/n" yazısı görünsün
         //Əgər console-a  y daxil etsəm məndən axtarış dəyərini daxil etməyimi istəməlidir və FullName field-ində həmin axtarış dəyəri olan bütün employeelərin məlumatları console pəncərəsində göstərilməlidir
         //Əgər console-a n daxil etsəm proses bitməlidir
         //Əgər console-a n və y-dən başqa bir şey daxil etsəm n və ya y daxil edənədək yenidən daxil etməyimi istəməlidir.
    }
}


