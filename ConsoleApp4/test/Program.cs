//#1
//using System;
//using System.Collections.Generic;
//using System.Text;
//namespace deledatetest
//{
//    delegate void OnjDelegate(int a, int b);
//    class MainApp
//    {
//        static void Plus(int a, int b) { Console.WriteLine("{0} + {1} = {2}", a, b, a + b); }
//        static void Minus(int a, int b) { Console.WriteLine("{0} - {1} = {2}", a, b, a - b); }
//        void Multiplication(int a, int b) { Console.WriteLine("{0} * {1} = {2}", a, b, a * b); }
//        void Division(int a, int b) { Console.WriteLine("{0} / {1} = {2}", a, b, a / b); }
//        static void Main()
//        {
//            Console.Write("두 수를 콤마로 구분하여 입력하시오 : ");
//            string str = Console.ReadLine();
//            string[] sArr = str.Split(',');
//            int[] iArr = Array.ConvertAll(sArr, i => int.Parse(i));

//            MainApp m = new MainApp();
//            OnjDelegate CallBack = (OnjDelegate)Delegate.Combine(
//            new OnjDelegate(MainApp.Plus),
//            new OnjDelegate(MainApp.Minus),
//            new OnjDelegate(m.Multiplication),
//            new OnjDelegate(m.Division));
//            CallBack(iArr[0], iArr[1]);
//        }
//    }
//}

//#2
using System;

public delegate void Callback();
class Program
{
    static void Main(string[] args)
    {
        MyClass my = new MyClass();
        //Direct call
        my.MyMethod1();
        my.MyMethod2();
        Console.WriteLine("------------");
        // Call via a delegate
        // MyClass의 GetCallback(Callback callBack) 메소드를 호출하여
        // MyMethod1, MyMethod2가 호출 되도록 코드를 완성하세요
        (채워주세요)
        (채워주세요)
 }
}
public class MyClass
{
    public MyClass() { }
    public void GetCallback(Callback callBack)
    {
        callBack();
    }
    public void MyMethod1()
    {
        Console.WriteLine("My Method 1");
    }
    public void MyMethod2()
    {
        Console.WriteLine("My Method 2");
    }
}

//#3
//using System;
//using System.IO;

//namespace DelegateAppl
//{
//    class PrintString
//    {
//        static FileStream fs;
//        static StreamWriter sw;
//        // 델리게이트 선언
//        (채워 주세요)
//    // 콘솔화면에 출력
//    public static void WriteToScreen(string str)
//        {
//            Console.WriteLine("The String is: {0}", str);
//        }
//        //파일에 출력
//        public static void WriteToFile(string s)
//        {
//            fs = new FileStream("d:\\message.txt",
//            FileMode.Append, FileAccess.Write);
//            sw = new StreamWriter(fs);
//            sw.WriteLine(s);
//            sw.Flush();
//            sw.Close();
//            fs.Close();
//        }
//        // 델리게이트를 인자로 받아 실행
//        // 결국 델리게이트가 참조하는 메소드 실행된다.
//        public static void sendString(printString ps)
//        {
//            (채워 주세요)
//        }
//        static void Main(string[] args)
//        {
//            (채워 주세요)
//    printString ps2 = new printString(WriteToFile);
//            sendString(ps1);
//            sendString(ps2);
//            Console.ReadKey();
//        }
//    }
//}