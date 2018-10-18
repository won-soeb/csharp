﻿using System;

namespace ConsoleApp6
{
    class EventPublisherArgs : System.EventArgs
    {
        public string myEventData;

        public EventPublisherArgs(string myEventData)
        {
            this.myEventData = myEventData;
        }       
    }
    class EventPublisher
    {
        public delegate void MyEventHandler(object sender, EventPublisherArgs e);
        public event MyEventHandler MyEvent;

        public void Do()
        {
            if(MyEvent != null)
            {
                EventPublisherArgs args = new EventPublisherArgs("데이터");
                MyEvent(this, args);
            }
        }
    }
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            p.MyEvent += new EventPublisher.MyEventHandler(doAction);
            p.Do();
        }
        static void doAction(object sender, EventPublisherArgs e)
        {
            Console.WriteLine("MyEvent라는 이벤트 발생");
            Console.WriteLine("이벤트 매개변수 : " + e.myEventData);
        }
    }
}

