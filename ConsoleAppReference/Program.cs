using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestSample;

namespace ConsoleAppReference
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            int? result = calculator.Add(5, 6);
            Console.WriteLine(result);
            if (result != 11)
                throw new InvalidOperationException();
            Console.ReadLine();
        }
    }
}
