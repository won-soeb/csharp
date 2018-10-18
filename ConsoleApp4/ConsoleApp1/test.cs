﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [AdditionalInfo("홍길동","2018/10/1",Download ="http://ojc.asia")]
    class Test
    {
        static void Main()
        {
            Type type = typeof(Test);
            foreach(Attribute attr in type.GetCustomAttributes(true))
            {
                AdditionalInfoAttribute info = attr as AdditionalInfoAttribute;
                if(info != null)
                {
                    Console.WriteLine("Name={0},Update={1},Download={2}", info.Name, info.Update, info.Download);
                }
            }
        }
    }
}
