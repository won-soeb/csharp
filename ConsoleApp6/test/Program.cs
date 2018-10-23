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

//#6(보류)
using System;

class Prime
{
    public static void Main()
    {
        Console.WriteLine("자연수를 하나 입력하세요.");
        int num = int.Parse(Console.ReadLine());
        int result = 2;
        int sosu(int mok)
       
                
        for (int i = 2; i <= num; i++)
        {
            result += sosu(i);
        }
        Console.WriteLine("입력한숫자 {0}까지의 소수의 합: {1}", num, result);
    }
}

//#7
//using System;

//namespace tutorialspoint
//{
//    class Student
//    {
//        private string code = "N.A";
//        private string name = "not known";
//        private int age = 0;
//        // Declare a Code property of type string:
//        public string Code
//        {
//            get { return code; }
//            set { code = value; }
//        }
//    // Declare a Name property of type string:
//    public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        // Declare a Age property of type int:
//        public int Age
//        {
//            get { return age; }
//            set { age = value; }
//        }  
//        public override string ToString()
//    {
//        return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
//    }
//}

//class ExampleDemo
//{
//    public static void Main()
//    {
//        // Create a new Student object:
//        Student s = new Student();
//        // Setting code, name and the age of the student
//        s.Code = "001";
//        s.Name = "Zara";
//        s.Age = 9;
//        Console.WriteLine("Student Info: {0}", s);
//        //let us increase age
//        s.Age += 1;
//        Console.WriteLine("Student Info: {0}", s);
//        Console.ReadKey();
//    }
//}
//}

//#8
//using System;

//public class Customer
//{
//public int ID { get; set; }
//public string Name { get; set; }
//}

//public class AutoImplementedCustomerManager
//{
//    static void Main()
//    {
//        Customer cust = new Customer();
//        cust.ID = 1;
//        cust.Name = "Amelio Rosales";
//        Console.WriteLine("ID: {0}, Name: {1}", cust.ID, cust.Name);
//        Console.ReadKey();
//    }
//}

//#9
//using System;

//namespace IndexerApplication
//{
//    class IndexedNames
//    {
//        private string[] namelist = new string[size];
//        static public int size = 10;
//        public IndexedNames()
//        {
//            for (int i = 0; i < size; i++)
//                namelist[i] = "N. A.";
//        }
//        public string this[int index]
//        {
//            get
//            {
//                string tmp;
//                if (index >= 0 && index <= size - 1)
//                {
//                    tmp = namelist[index];
//                }
//                else
//                {
//                    tmp = "N. A";
//                }
//                return tmp;
//            }
//            set
//            {
//                if (index >= 0 && index <= size - 1)
//                {
//                    namelist[index] = value;
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            IndexedNames names = new IndexedNames();
//            names[0] = "Zara";
//            names[1] = "Riz";
//            names[2] = "Nuha";
//            names[3] = "Asif";
//            names[4] = "Davinder";
//            names[5] = "Sunil";
//            names[6] = "Rubic";
//            for (int i = 0; i < IndexedNames.size; i++)
//            {
//                Console.WriteLine(names[i]);
//            }
//            Console.ReadKey();
//        }
//    }
//}

//#10
//실행결과 : 2

//#11
//실행결과: 
//2
//2
//2
//2
//4
//(공백)
//2
//2

//#12
//실행결과: 2 4 6 8 10
//using System;
//using System.Linq;

//class Test {

//    public  static void Main() { 
//    int[] oneToTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//    var evenNumbers = oneToTen.Where(n => n % 2 == 0);

//    foreach (int i in evenNumbers)
//    Console.Write("{0} ", i);
//        }
//}

//#13
//실행결과: Rex Sean Stacy

//#14
//using System;

//class Program
//{
//    // declare delegate
//    public delegate void Print(int value);
//    static void Main(string[] args)
//    {
//        // Print delegate points to PrintNumber
//        Print printDel = PrintNumber;
//        printDel(100000);
//        printDel(200);
//        // Print delegate points to PrintMoney
//        printDel = PrintMoney;
//        printDel(10000);
//        printDel(200);
//    }
//    public static void PrintNumber(int num)
//    {
//        Console.WriteLine("Number: {0,-12:N0}", num);
//    }
//    public static void PrintMoney(int money)
//    {
//        Console.WriteLine("Money: {0:C}", money);
//    }
//}

//#15
//실행결과: 
//10 10 10 10 10 10 10 10 10 10
//Press a Key...
//라는 문구가 0~20ms 사이 임의의 시간대로 지연되어 출력된다.

//using System;
//using System.Threading;

//class Program
//{ 
//    public static void Main(string[] args)
//    {
//        Thread[] t = new Thread[10];
//        for (int tNum = 0; tNum < 10; tNum++)
//        {
//            t[tNum] = new Thread(() => {
//                Thread.Sleep(new Random().Next(20));
//                Console.Write(tNum + " ");
//            });
//            t[tNum].Start();
//        }
//        // wait for the threads to finish
//        for (int tNum = 0; tNum < 10; tNum++)
//        {
//            t[tNum].Join();
//        }
//        Console.WriteLine("\nPress a key...");
//        Console.Read();
//    }
//}

//#16
//using System;

//public delegate void EventHandler();
//class Program
//{
//    public static event EventHandler _show;
//    static void Main()
//    {
//        // Add event handlers to Show event. 
//        _show += Cat;
//        _show += Dog;
//        _show += Mouse;

//        // Invoke the event. 
//        _show();
//    }
//    static void Cat()
//    {
//        Console.WriteLine("Cat");
//    }
//    static void Dog()
//    {
//        Console.WriteLine("Dog");
//    }
//    static void Mouse()
//    {
//        Console.WriteLine("Mouse");
//    }
//}
