using System;
using System.Collections.Generic;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fracion1 = new Fraction(3, 7);
            var fracion2 = new Fraction(3, 7);
            Console.WriteLine(fracion1.NumbericRepresentation(2));
        }
    }
}
