using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" --------Temperature_Converter------- ");

            Console.WriteLine("Enter Temperature : ");
            double temp = double.Parse(Console.ReadLine());
            Console.WriteLine("What unit your temperature is ?  ");
            Console.WriteLine("1:it is Celsius ");
            Console.WriteLine("2: it is Fahrenheit  ");
            Console.Write("Enter your choice (1/2): ");
            int choise = int.Parse(Console.ReadLine());
            double result = 0;

            switch (choise)
            {

                case 1:
                    result = (temp * 1.8) + 32;
                     double F = result;
                     Console.WriteLine(F + "F");
                    break;


                case 2:
                    result = (temp - 32) % 1.8;
                      double C = result;
                    Console.WriteLine(C + "C");
                    break;
            }
          
            Console.ReadLine();
        }
    }
}
