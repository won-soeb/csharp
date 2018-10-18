#define SOUNDCARD
#define SPEAKER

using System;
using System.Diagnostics;

class Test
{
    [Conditional("SOUNDCARD")]
    static void isSound()
    {
        isSpeaker();
    }
    [Conditional("SPEAKER")]
    static void isSpeaker()
    {
        Console.WriteLine("음악듣기");
    }
    static void Main()
    {
        isSound();
    }
}
