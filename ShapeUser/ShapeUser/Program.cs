﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeUser
{
    using System;
    using Shapes;

    public class ShapeUser
    {
        static void Main()
        {
            Circle c = new Circle(1);
            Console.WriteLine("Area = {0}", c.Area());
        }
    }
}