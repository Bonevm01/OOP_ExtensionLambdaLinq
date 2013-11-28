using System;
using System.Threading;

class Timer
{
    public uint loopTime { get; set; }

    public Timer(uint time)
    {
        this.loopTime = time;
    }

    public void Run(int r)
    {
        int row = r;
        for (int i = 0; i <= this.loopTime; i++)
        {
            Console.SetCursorPosition(0, row);
            Console.Write(i);
            if (i!=this.loopTime)
            {
                Thread.Sleep(1000);
            }
            
        }
        Console.WriteLine();
    }
}
