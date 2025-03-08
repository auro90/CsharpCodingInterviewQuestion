using System;
using System.Reflection.Metadata.Ecma335;

public class Reverse
{

    public string ReverseASingleWordWithoutUsingBuildInFunction(string toReverse)
    {
        char[] input = toReverse.ToCharArray();
        string results = String.Empty;

        for(int i = input.Length-1;i>=0;i--)
        {
            results =results + input[i];
        }
        Console.WriteLine($"{toReverse} -After Reverse- {results}");
        return results;
    }

    public string ReverseEntireStringWithoutUsingBuildInFunction(string toReverse)
    {
        char[] input = toReverse.ToCharArray();
        string results = String.Empty;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            results = results + input[i];
        }
        Console.WriteLine($"{toReverse} -After Reverse- {results}");
        return results;
    }

    public string ReverseWordsInAStringWithoutUsingBuildInFunction(string toReverse)
    {
        string[] words = toReverse.Split(' ');
        string results = String.Empty;
        for (int i = words.Length - 1; i >= 0; i--)
        {
            results = results + words[i] + " ";
        }
        Console.WriteLine($"{toReverse} -After Reverse- {results}");
        return results;
    }
}
