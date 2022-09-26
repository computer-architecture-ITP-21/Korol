using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 101;
            Console.WriteLine($"Исходное чилсо (10 система) - {num}");
            ConvertNumber convertNumber = new ConvertNumber();
            Console.WriteLine($"Конвертированное число (8 система) - {convertNumber.ConvertFrom10TO8(num)}");
        }
    }
}