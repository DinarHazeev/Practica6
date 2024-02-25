using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double f = 3*Math.Sin(x+2);
        }
    }
}
