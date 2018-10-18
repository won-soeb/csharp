using System;

namespace EventTest
{
    delegate void MyDelegate(int i);
    class EventPublisher
    {
        public event MyDelegate ClapEvent;

        public void Clap(int num)
        {
            if (num % 2 == 0) ClapEvent(num);
        }
    }
        class EventSub {
            public static void Main()
            {
                EventPublisher p = new EventPublisher();
            p.ClapEvent += (num) => {
                Console.WriteLine("{0} : 짝", num);
            };
                int[] iArr = Array.ConvertAll(
                    (Console.ReadLine()).Split(','),
                    i => int.Parse(i));
                foreach(int i in iArr) { p.Clap(i); }
            }
        }
}



