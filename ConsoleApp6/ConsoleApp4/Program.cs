﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Action act1 = () => Console.WriteLine("오라클커뮤니티");
            act1();

            int ret = 0;
            Action<int> act2 = (x) => ret = x * x;//리턴을 안하므로
            act2(2);//다시  호출해줘야한다
            Console.WriteLine("act2(2) :: {0}", ret);

            Action<double, double> act3 = (x, y) =>
            {
                double d = x / y; Console.WriteLine("Action<t1,t2>({0},{1}) : {2}", x, y, d);
            };
            act3(100, 3);
        }
    }
}
