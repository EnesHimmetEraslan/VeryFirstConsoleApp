using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Bir sayı giriniz: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir sayı daha giriniz: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayıların çarpımı: " + num1 * num2 );
            Console.ReadKey();
        }
    }
}
