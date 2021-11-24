using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_attempt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первый катет:");
            var katetOne = double.Parse(Console.ReadLine());
            Console.WriteLine("введите второй катет:");
            var katetTwo = double.Parse(Console.ReadLine());
            double square = katetOne * katetTwo / 2;
            double gipotenuza = Math.Sqrt(katetOne * katetOne + katetTwo * katetTwo);
            double perimetr = katetTwo + katetOne + gipotenuza;
            Console.WriteLine($"площадь равна: {square}");
            Console.WriteLine($"периметр равен: {perimetr}");


            Console.ReadKey();
        }
    }
}
