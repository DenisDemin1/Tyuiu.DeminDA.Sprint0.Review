using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DeminDA.Sprint0.Review.V0.Lib;

namespace Tyuiu.DeminDA.Sprint0.Review.V0
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;

            Console.WriteLine("Введите первое число x");
            x = Convert.ToInt32(Console.ReadLine());

            int y;

            Console.WriteLine("Введите второе  число y");
            y = Convert.ToInt32(Console.ReadLine());

            int z;

            Console.WriteLine("Введите третье  число z");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ответ = " + DataService.Calc(x, y, z));

            Console.ReadLine();
        }
    }
}
