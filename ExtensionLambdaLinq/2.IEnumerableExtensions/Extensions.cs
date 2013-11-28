using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

public static class Extensions
{

    public static string ToString<T>(this IEnumerable<T> list)
    {
        StringBuilder output = new StringBuilder();
        output.Append("{ ");
        foreach (var item in list)
        {
            output.Append(item);
            output.Append(" ");
        }
        output.Append("}");
        return output.ToString();
    }

    public static T Min<T>(this IEnumerable<T> list) where T : IComparable
    {
        T tempor = default(T);
        bool isFirst = true;
        foreach (var item in list)
        {
            if (isFirst)
            {
                tempor = item;
                isFirst = false;
            }
            if (item.CompareTo(tempor) < 0)
            {
                tempor = item;

            }
        }

        return tempor;
    }

    public static T Max<T>(this IEnumerable<T> list) where T : IComparable
    {
        T tempor = default(T);
        bool isFirst = true;

        foreach (var item in list)
        {
            if (isFirst)
            {
                tempor = item;
                isFirst = false;
            }
            if (item.CompareTo(tempor) > 0)
            {
                tempor = item;
            }
        }

        return tempor;
    }

    public static double Average<T>(this IEnumerable<T> list) //double has the biggest range
    {
        dynamic sum = 0;
        double count = 0;
        foreach (var item in list)
        {
            sum += item;
            count++;
        }
        if (count == 0)
        {
            throw new ArgumentException("An empty array can't have average value.");
        }
        return sum / count;
    }

    public static T Sum<T>(this IEnumerable<T> list) //It is possible to have Overflow exeption
    {
        dynamic sum = 0;
        foreach (var item in list)
        {
            sum += item;
        }
        return sum;
    }

    public static T Product<T>(this IEnumerable<T> list) //It is possible to have Overflow exeption
    {
        dynamic prod = 1;
        foreach (var item in list)
        {
            prod *= item;
        }
        
        return prod;
    }
}
