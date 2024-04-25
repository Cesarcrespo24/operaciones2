using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese primer numero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese segundo numero:");
            int num2= int.Parse(Console.ReadLine());

            int suma = num1 + num2;
            Console.WriteLine("la suma es :" + suma);
            Console.ReadKey();
                
        }
    }
}
