﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Age
    {
        public void Number()
        {
            Console.WriteLine("Enter Your Age");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You Look Older Than {Age}");
        }
    }
}
