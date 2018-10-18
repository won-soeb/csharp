//#1
//using System;

//namespace ConsoleApplication3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //가변배열, 처음방에는 1,2 두번째방에는 1,2,3 세번째방에는 1,2,3,4
//            int[][] a = new int[3][];
//            a[0] = new int[] { 1, 2 };
//            a[1] = new int[] { 1, 2, 3 };
//            a[2] = new int[] { 1, 2, 3, 4 };
//            //3행 2열, 이차원배열 1행은 (1,2), 2행은 (3,4), 3행은 (5,6)
//            int[,] b = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
//            //가변배열 출력
//            foreach (int[] i in a)
//            {
//                foreach (int j in i)
//                {
//                    Console.Write(j + " ");
//                }
//            }
//            Console.WriteLine("\n---------------\n");
//            //이차원 배열 출력
//            foreach (int i in b)
//            {
//                Console.Write(i + " ");
//            }
//        }
//    }
//}

//#2

using System;
using System.Collections.Generic;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            //----4행2열
            int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for (int i = 0; i < twoDim.Length; i++)//
            {
                for (int j = 0; j < twoDim.Length ; j++)//
                {
                Console.Write(twoDim[i, j]);
            }
        }
        Console.WriteLine();
            foreach (int i in twoDim)//
            {
                Console.Write(i);
            }
        }
    }
}
