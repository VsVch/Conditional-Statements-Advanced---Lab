﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string femail = Console.ReadLine();

            if (age >= 16 && femail == "m")
            {
                Console.WriteLine("Mr.");
            }
            else if (age < 16 && femail == "m")
            {
                Console.WriteLine("Master");

            }
            else if (age >= 16 && femail == "f")
            {
                Console.WriteLine("Ms.");

            }
            else if (age < 16 && femail == "f")
            {
                Console.WriteLine("Miss");
            }

        }
    }
}
