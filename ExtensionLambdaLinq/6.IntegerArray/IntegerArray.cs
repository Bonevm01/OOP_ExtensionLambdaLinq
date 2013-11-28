//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.


using System;

using System.Linq;

class IntegerArray
{
    static void Main()
    {
        int[] arr = { -12, 7, -5, 21, 19, 32, -21, 5, 0, 42 };
        var shortList = arr.Where(x => x % 7 == 0 && x % 3 == 0);

        Console.WriteLine("(Lambda)Integers divisable by 7 and 3 are:");
        foreach (int item in shortList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("(LINQ) Integers divisable by 7 and 3 are:");
        var newList = from number in arr
                      where number % 7 == 0 && number % 3 == 0
                      select number;

        foreach (int item in newList)
        {
            Console.WriteLine(item);
        }
    }
}