//Using delegates write a class Timer that has can execute certain method at each t seconds.

//I decided that the goal of this problem is to add two methods to a delegate - the first is a timer and the second - a simple method
//The idea is to invoke several times the delegate and each time we have to wait the first method -the timer to reach its value and after
//that the second method will be executed.

using System;

public delegate void SomeTestdelegate(int a);

class TimerTest
{
    static void Main()
    {
        Timer timer = new Timer(5);//5 seconds is my timer loop
        int row = 0;

        //Add two void methods with an int parameter to the delegate - the first method is an instance method to class Timer
        // the second method is a static void method
        SomeTestdelegate d = timer.Run;
        d += PrintMessage;

        //invoke delegate several (3) times
        for (int i = 0; i < 3; i++)
        {
            d(row);
            row += 2;
        }
        
    }

    static void PrintMessage(int s)
    {
        Console.WriteLine("Test message N{0}.", s/2);
    }
}
