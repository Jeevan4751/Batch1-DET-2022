﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestEMP
{
        public static void Main()
        {
            EMP e = new EMP(22825, "Manasa", new DateOnly(2021, 8, 1));
            Console.WriteLine($"Years of experience{e.GetYearsofExp()}");
        }
    }
}
