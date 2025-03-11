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

    public string ReverseStringRecursively(string toReverse)
    {
        if (toReverse.Length == 1)
        {
            return toReverse;
        }
        else
        {
            return ReverseStringRecursively(toReverse.Substring(1)) + toReverse[0] ;
        }
    }

    public void ReverseFileContent(string path)
    {
        string fileContent = File.ReadAllText(path);
        File.WriteAllText(path, new string (fileContent.Reverse().ToArray()));
    }

    public string ReverseEveryKCharacters(string toReverse, int k)
    {
        char[] arr = toReverse.ToCharArray();

        for (int i = 0; i < arr.Length; i += k)
        {
            int left = i;
            int right = Math.Min(i + k - 1, arr.Length - 1); 
            while (left < right)
            {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }
        return new string(arr);
    }

    public void ReverseCharArray(char[] arr)
    {
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            (arr[left], arr[right]) = (arr[right], arr[left]);
            left++;
            right--;
        }
        //for (int left = 0, right = arr.Length - 1; left < right; left++, right--)
        //{
        //    (arr[left], arr[right]) = (arr[right], arr[left]);
        //}
    }

}
