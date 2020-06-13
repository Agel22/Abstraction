using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Polymorphism
{
    public class Burung: Animals
    {
        public override void Speak()
        {
            Console.WriteLine("prittt.....prittt");
        }
    }
}