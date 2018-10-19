//#1
//using System;

//namespace test1
//{
//    class Sum
//    {
//        static void Main()
//        {
//            Console.WriteLine("더할 숫자들을 콤마로 구분하여 입력하세요.");
//            double[] input = Array.ConvertAll(
//                          (Console.ReadLine()).Split(','), i => double.Parse(i));
//            double sum = 0;           
//            for (int i = 0; i < input.Length; i++)
//            {
//                sum = sum + input[i];
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}

//#2
//using System;

//namespace test2
//{
//    class OddTester
//    {
//        static void Main()
//        {
//            Console.WriteLine("정수 하나를 입력하세요.");
//            int input = int.Parse(Console.ReadLine());
//                if (input % 2 == 0)
//                {
//                    Console.WriteLine("입력하신 숫자 {0} 은 짝수입니다.", input);
//                }
//                else
//                {
//                    Console.WriteLine("입력하신 숫자 {0} 은 홀수입니다.", input);
//                }
//        }
//    }
//}

//#3
//using System;

//namespace test3
//{
//    class Reversion
//    {
//        static void Main(string[] args)
//        {
//            int num1, num2, temp;
//            Console.Write("\nEnter the First Number : ");

//            num1 = int.Parse(Console.ReadLine());
//            Console.Write("\nEnter the Second Number : ");

//            num2 = int.Parse(Console.ReadLine());
//  //채우기//
//            temp = num1;
//            num1 = num2;
//            num2 = temp;
//  //채우기//
//            Console.Write("\nAfter Swapping : ");
//            Console.Write("\nFirst Number : " + num1);
//            Console.Write("\nSecond Number : " + num2);
//            Console.Read();
//        }
//    }
// }

//#4
//using System;
//class Rectangle
//{
//    static void Main()
//    {
//        for(int i=1; i<=5; i++)
//        {
//            for (int j = 1; j <= i; j++)
//            {
//                if(i % 2 == 1)
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//#5
//Enter a Number : 123
//Reverse of Entered Number : 321

//코드를 완성하세요

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Program
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int num, reverse = 0;
//            Console.WriteLine("Enter a Number : ");
//            num = int.Parse(Console.ReadLine());
//            while (num != 0)
//            {
//                reverse = (reverse * 10) + (num % 10);
//                num = num / 10;
//            }
//            Console.WriteLine("Reverse of Entered Number is : " + reverse);
//            Console.ReadLine();
//        }
//    }
//}

//#6
using System;

class Nano
{
    public static void Main()
    {
        Console.WriteLine("자연수를 하나 입력하세요.");
        int num = int.Parse(Console.ReadLine());
        for (int i = 2; i < num; i++)
        {
            int mok = num / i;
            int na = num % i;
            if ((mok != 0) && (na == 0))
            {
                Console.WriteLine(mok);
            }
        }
    }
}