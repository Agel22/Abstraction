using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Polymorphism
{
    public class Kucing : Animals
    {
        public override void Speak()
        {
            Console.WriteLine("Meong....Meong");
        }
    }
}