﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> func1 = () => 10;
            Console.WriteLine(func1());//10

            Func<int, int> func2 = (x) => x * x;
            Console.WriteLine("func2 :: {0}", func2(2));//4

            Func<string, string> func3 = (str) => str.ToUpper();
            Console.WriteLine("func3 :: {0}", func3("oraclecommunity"));//대문자로 바뀜

            Func<string, char[]> func4 = delegate (string str)
            {
                return str.ToArray();
            };
            Console.WriteLine("func4 :: 배열크기={0}, 처음요소={1}", 
                func4("oraclecommunity").Count(), func4("oraclecommunity ")[0]);

            Func<string, string> func5 = convertUpper;
            Console.WriteLine("onj를 대문자로 {0}", func5("onj"));

            Func<string, string> func6 = (str) => str.ToLower();
            string[] onjs = { "ONJ", "ORACLEJAVA", "ORACLEJAVACOMMUNITY.CO.KR" };
            IEnumerable<string> onjWords = onjs.Select(func6);//Select는 쿼리식
            foreach (string word in onjWords) Console.WriteLine(word);

        }
        static string convertUpper(string str) { return str.ToUpper(); }
    }
}
