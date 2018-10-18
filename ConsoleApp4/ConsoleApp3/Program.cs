using System;

namespace ConsoleApp3
{
    class EventPublisher
    {
        //public delegate void MyEventHandler();
        public event EventHandler MyEvent;
        public void Do()
        {
            if(MyEvent != null)
            {
                MyEvent(null, null);
            }
            //MyEvent?.Invoke();
        }
    }
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            p.MyEvent += new EventHandler(doAction);
            p.Do();
        }
        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent라는 이벤트 발생");
        }
    }
}
