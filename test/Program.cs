//#1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace 사칙연산
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("두수를 입력하세요.");
            Console.WriteLine("예 : 3,5");
            string str = Console.ReadLine();
            str.Trim();
            string[] strarr = str.Split(',');
            if (strarr.Length != 2)
            {
                Console.WriteLine("숫자2개를 콤마로 구분해서 입력하세요~");
                return;
            }
            int first, second;
            try
            {
                first =  int.Parse(strarr[0]);
                second = int.Parse(strarr[1]);
            }
            catch
            {
                Console.WriteLine("입력이 잘못되었습니다.");
                return;
            }
            Console.WriteLine("{0} + {1} = {2}", first, second, Calc(first, second, "+"));
            Console.WriteLine("{0} - {1} = {2}", first, second, Calc(first, second, "-"));
            Console.WriteLine("{0} * {1} = {2}", first, second, Calc(first, second, "*"));
            Console.WriteLine("{0} / {1} = {2}", first, second, Calc(first, second, "/"));
        }
        static double Calc(int first, int second, string op)
        {
            double result = 0;
            switch (op)
            {
                case "+":
                    first + second;
                    break;
                case "-":
                    first - second;
                    break;
                case "*":
                    first * second;
                    break;
                case "/":
                    first / second;
                    break;
                default:
                    Console.WriteLine("연산기호를 정확히 입력하세요");
                    break;
            }
            return result;
        }
    }
}

//String[] sArr = s.split(',');
//int[] iArr = Array.Convert(sArr, s => int.Parse(s));

//#2
//using System;

//namespace Loop
//{
//    class ForLoop
//    {
//        public static void Main(string[] args)
//        {
//            for (int i =0; i < 3; i++)
//            {
//                int j = i;
//                Console.WriteLine("i = {0} and j = {1}", i, j);
//            }
//        }
//    }
//}

//#3
//using System;

//namespace Loop
//{
//    class ForLoop
//    {
//        public static void Main(string[] args)
//        {
//            int i = 1;
//            for (i = 1;i<=5;)
//            {
//                Console.WriteLine("C# For Loop: Iteration {0}", i);
//                i++;
//            }
//        }
//    }
//}


