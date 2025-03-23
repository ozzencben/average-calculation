using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            averageCalculation averageCalculation = new averageCalculation();


            Console.WriteLine("Öğrenci bilgilerini giriniz.");
            
            Console.Write("Öğrenci ad : ");
            string name = Console.ReadLine();

            Console.Write("Öğrenci soyad : ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Öğrencinin  notlarını giriniz.");

            Console.Write("Not 1 : ");
            decimal number1 = decimal.Parse(Console.ReadLine());
           
            Console.Write("Not 2 : ");
            decimal number2 = decimal.Parse(Console.ReadLine());
            
            Console.Write("Not 3 : ");
            decimal number3 = decimal.Parse(Console.ReadLine());

            averageCalculation.avrCalculate(name, lastName, number1, number2, number3);
        }
    }
}
