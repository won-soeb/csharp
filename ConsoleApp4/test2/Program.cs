//1. 괄호채우기
//[결과]
//Static method: 10
//My instance: 5

//using System;
//public delegate string FirstDelegate(int x);
//class DelegateTest
//{
//    string name;
//    static void Main()
//    {
//        FirstDelegate d1 = new FirstDelegate(StaticMethod);
//        DelegateTest instance = new DelegateTest();
//        instance.name = "My instance";

//        FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod);//
//        Console.WriteLine(d1(10)); // Writes out "Static method: 10"
//        Console.WriteLine(d2(5));  // Writes out "My instance: 5"
//    }
//    static string StaticMethod(int i)
//    {
//        return string.Format("Static method: {0}", i);
//    }
//    string InstanceMethod(int i)
//    {
//        return string.Format("{0}: {1}", name, i);
//    }
//}


//2. 실행결과는?
//add operation
//remove operation

//3. 괄호채우기

//[결과]
//iAnswer = 7
//Multiple of five reached!
//iAnswer = 10

using System;
public class Adder
{
    public delegate void EventRaiser();
    public event EventRaiser OnMultipleOfFiveReached;
    public int Add(int x, int y)
    {
        int iSum = x + y;
        if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null))
        {
            (채워주세요)//
        }
        return iSum;
    }
}
class Program
{
    static void Main()
    {
        Adder a = new Adder();
        a.OnMultipleOfFiveReached += MultipleOfFiveReached;//
        int iAnswer = a.Add(4, 3);
        Console.WriteLine("iAnswer = {0}", iAnswer);
        iAnswer = a.Add(4, 6);
        Console.WriteLine("iAnswer = {0}", iAnswer);
        Console.ReadKey();
    }
    static void MultipleOfFiveReached()
    {
        Console.WriteLine("Multiple of five reached!");
    }
}


//4. 이벤트 호출시 데이터를 넘기는 예제 입니다.괄호채워 주세요

//[실행결과]

//iAnswer = 7

//Multiple of five reached:

//iAnswer = 10


//using System;

//class Program
//{
//    static void Main()
//    {
//        Adder a = new Adder();
//        a.OnMultipleOfFiveReached += (채워주세요);
//        int iAnswer = a.Add(4, 3);
//        Console.WriteLine("iAnswer = {0}", iAnswer);
//        iAnswer = a.Add(4, 6);
//        Console.WriteLine("iAnswer = {0}", iAnswer);
//        Console.ReadKey();
//    }
//    static void a_MultipleOfFiveReached(object sender, MultipleOfFiveEventArgs e)
//    {
//        Console.WriteLine("Multiple of five reached: ", e.Total);
//    }
//}

//public class Adder
//{
//    public event EventHandler<MultipleOfFiveEventArgs> OnMultipleOfFiveReached;
//    public int Add(int x, int y)
//    {
//        int iSum = x + y;
//        if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null))
//        {
//            OnMultipleOfFiveReached(채워 주세요. );
//        }
//        return iSum;
//    }
//}
//public class MultipleOfFiveEventArgs : (채워주세요)
//{
//    public MultipleOfFiveEventArgs(int iTotal)
//    {
//        Total = iTotal;
//    }
//    public int Total { get; set; }
//}

//5. 

//다이렉트 호출 스크립트 입니다.


//using System;

//namespace Akadia.NoDelegate
//{
//    public class MyClass
//    {
//        public void Process()
//        {
//            Console.WriteLine("Process() begin");
//            Console.WriteLine("Process() end");
//        }
//    }
//    public class Test
//    {
//        static void Main(string[] args)
//        {
//            MyClass myClass = new MyClass();
//            myClass.Process();
//        }
//    }
//}

//델리게이트를 사용하여 호출하는 예제로 재작성 하세요.

//1. 델리게이트를 별도로 선언하여

//2. Action 델리게이트를 이용하여


//6. 괄호 채워 주세요

//[c:\GitHub\process.log 파일의 내용]
//Process() begin
//Process() end

//using System;
//using System.IO;

//namespace Akadia.SimpleDelegate
//{
//    public class MyClass
//    {
//        public delegate void LogHandler(string message);
//        public void Process(LogHandler logHandler)
//        {
//            (채워 주세요...)
//        }
//    }
//    public class FileLogger
//    {
//        FileStream fileStream;
//        StreamWriter streamWriter;
//        // Constructor
//        public FileLogger(string filename)
//        {
//            fileStream = new FileStream(filename, FileMode.Create);
//            streamWriter = new StreamWriter(fileStream);
//        }
//        // Member Function which is used in the Delegate
//        public void Logger(string s)
//        {
//            streamWriter.WriteLine(s);
//        }
//        public void Close()
//        {
//            streamWriter.Close();
//            fileStream.Close();
//        }
//    }
//    public class TestApplication
//    {
//        static void Main(string[] args)
//        {
//            FileLogger fl = new FileLogger("c:\\GitHub\\process.log");
//            MyClass myClass = new MyClass();
//            MyClass.LogHandler myLogger = (채워 주세요 );
//            (채워 주세요  )
//            fl.Close();
//        }
//    }
//}