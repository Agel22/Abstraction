using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Polymorphism
{
    public class program
    {
        public static void Main(string[] args)
        {
            Animals animals = new Animals();

            animals = new Kucing();
            animals.Speak();

            Console.WriteLine();
            animals = new Burung();
            animals.Speak();

            Console.ReadKey();
        }
    }
}