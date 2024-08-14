using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             

            Console.WriteLine("Введите коэфициент К");
            double K= double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэфициент B");
            double B= double.Parse(Console.ReadLine());
            Lin lin = new Lin(K, B);
            Console.WriteLine(lin.Root());
            Console.ReadLine();
        }
    }
}
