//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
// sum, product, min, max, average.


using System;
using System.Collections.Generic;

class IEnumExtensionsTest
{
    static void Main()
    {
        int[] arr = { 14, 3, 5, 7, 4 };
        int min = arr.Min();
        int max = arr.Max();
        Console.WriteLine("The list contains:");
        Console.WriteLine(arr.ToString<int>());
        Console.WriteLine("Min is {0}; Max is {1}", min, max);
        Console.WriteLine("Average-->{0:f2}", arr.Average());
        Console.WriteLine("Sum-->{0:f2}", arr.Sum());
        Console.WriteLine("Product-->{0:f2}", arr.Product());

        Console.WriteLine();
        double[] array =  { 1.2445, 9.256, -6.154, -3.1265, 9.214, 0.0247, -1.0284 }; //double range is bigger than decimal and that's why average is double. It is not possible to convert the whole range of double to decimal
        Console.WriteLine("The list contains: {0}", array.ToString<double>());
        Console.WriteLine("Min is {0}; Max is {1}", array.Min(), array.Max());
        Console.WriteLine("Average-->{0:f2}", array.Average());
        Console.WriteLine("Sum-->{0:f2}", array.Sum());
        Console.WriteLine("Product-->{0:f2}", array.Product());

        Console.WriteLine();
        List<string> myList = new List<string>() {"gfa","bgsg","kgsg","agsg","sgsg" };
        Console.WriteLine("The list contains: {0}", myList.ToString<string>());
        Console.WriteLine("Min is {0}; Max is {1}", myList.Min(), myList.Max());

        Console.WriteLine();
        int[] test = new int[3];
        Console.WriteLine("Min in an empty int array is {0}; Max-->{1} (default value)", test.Min(), test.Max()); //Or to throw exeptions


    }
}
