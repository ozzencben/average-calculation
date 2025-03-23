using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class averageCalculation
    {

        public void avrCalculate(string lastName, string name, decimal number1, decimal number2, decimal number3)
        {

            Console.WriteLine("Öğrenci ad : " + name);
            Console.WriteLine("Öğrenci Soyad : " + lastName);

            decimal result = (number1 + number2 + number3) / 3;

            if (result >= 45)
            {
                Console.WriteLine("Ortalamanız : " + result + " - Tebrikler! Geçtiniz.");
            }
            else
            {
                Console.WriteLine("Ortalamanız : " + result + " - Maalesef, kaldınız.");
            }

            Console.ReadLine();
        }

    }
}
