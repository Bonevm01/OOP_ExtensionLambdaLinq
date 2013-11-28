//Using delegates write a class Timer that has can execute certain method at each t seconds.

//I decided to practise how to use a delegate as a parameter to another method
using System;
using System.Threading;

public delegate void SomeDelegate();

class TimerTest
{
    static void Main()
    {
        Timer timer = new Timer(12, 3);
        SomeDelegate d = PrintMessage;
        timer.Run(d);
    }

    //Method that will be executed several times
    static void PrintMessage()
    {
        Console.WriteLine("Test message.");
    }


}

//class Timer with an instance method with a delegate as parameter
class Timer
{
    public uint total { get; set; }
    public uint interval { get; set; }

    public Timer(uint totalTime, uint loopTime)
    {
        this.total = totalTime;
        this.interval = loopTime;
    }

    public void Run(SomeDelegate a)
    {
        int row = 1;
        for (int i = 0; i <= this.total; i++)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(i);

            if (i!=0 && i%this.interval ==0)
            {
                Console.SetCursorPosition(0, row);
                a();
                row++;
            }
            Thread.Sleep(1000);
        }
    }
}


