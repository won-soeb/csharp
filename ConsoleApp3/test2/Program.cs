//using System;
//using System.Collections;
//using System.Collections.Generic;
//namespace ConsoleApplication6
//{
//    class Stack<T>
//    {
//        int top = 0;
//        T [] ar = new T [10];
//        public void Push(T obj)
//        {
//            ar[top] = obj;
//            top++;
//        }
//        public T Pop()
//        {
//            top--;
//            return ar[top];
//        }
//    }

//    class StackTest
//    {
//        static void Main()
//        {
//            Stack s = new Stack();
//            s.Push(1);
//            s.Push(2);
//            s.Push(3);
//            Console.WriteLine(s.Pop());
//            Console.WriteLine(s.Pop());
//            Console.WriteLine(s.Pop());
//            s.Push("KOREA");
//            s.Push("대한민국");
//            s.Push("서울");
//            Console.WriteLine(s.Pop());
//            Console.WriteLine(s.Pop());
//            Console.WriteLine(s.Pop());
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    interface IEquatable<T>
    {
        (채워주세요 ) Equals(T obj);//
    }
    public class Emp : IEquatable<Emp>
    {
        public string name(채워 주세요);//
        public int sabun { get; set; }
        // Implementation of IEquatable<T> interface
        //name, sabun이 같을 경우 true 리턴
        public bool Equals(Emp e)
        {
            (채워 주세요 )//
        }
    }
    public class Car : (채워 주세요 )//
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        // Implementation of IEquatable<T> interface
        //Maker, Model, Year가 같을 경우 true 리턴
        public bool Equals(Car car)
        {
            (채워주세요)//
        }
    }
    public class CarTest
    {
        static void Main()
        {
            Car c1 = new Car()
            {
                Maker = "현대",
                Model = "그랜저",
                Year = "2016"
            };
            Car c2 = new Car()
            {
                Maker = "현대",
                Model = "그랜저",
                Year = "2015"
            };
            if (c1.Equals(c2))
            {
                Console.WriteLine("c1와 c2는 같다.");
            }
            else
            {
                Console.WriteLine("c1와 c2는 다르다.");
            }
            Emp e1 = new Emp()
            {
                name = "홍길이",
                sabun = 1004
            };
            Emp e2 = new Emp()
            {
                name = "홍길이",
                sabun = 1004
            };
            if (e1.Equals(e2))
            {
                Console.WriteLine("e1와 e2는 같다.");
            }
            else
            {
                Console.WriteLine("e1와 e2는 다르다.");
            }
        }
    }
}