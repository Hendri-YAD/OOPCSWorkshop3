﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RationalLibraryISS;

namespace OOPCSWorkshop3
{
    class Program4
    {
        static void Main(string[] args)
        {
            Rational a = new Rational(3, 4);
            Rational b = new Rational(4, 5);
            Rational c = a.Add(b);
            Console.WriteLine(c.StrVal());
            c = b.Subtract(a);
            Console.WriteLine(c.StrVal());
        }
    }
}
