//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns
// new StringBuilder and has the same functionality as Substring in the class String.


using System;
using System.Text;

public static class Extension
{
    public static StringBuilder SubStringBuilder(this StringBuilder str, int index, int length)
    {
        StringBuilder output = new StringBuilder();
        string tempor = str.ToString();
        string sub = tempor.Substring(index, length);
        output.Append(sub);
                
        return output;
    }
}

class SubStringBuilderTest
{
    static void Main()
    {
        StringBuilder myTest = new StringBuilder();
        myTest.Append("Alabalanica");
        StringBuilder substr = myTest.SubStringBuilder(3, 5);
        
        Console.WriteLine("The whole StringBuilder contains {0}", myTest.ToString());
        Console.WriteLine("The part which starts at position 3 with length 5 is {0}", substr.ToString());
    }
}
