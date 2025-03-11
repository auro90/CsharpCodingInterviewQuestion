// See https://aka.ms/new-console-template for more information
Reverse reverse = new Reverse();
reverse.ReverseASingleWordWithoutUsingBuildInFunction("World");
reverse.ReverseEntireStringWithoutUsingBuildInFunction("Hello World");
reverse.ReverseWordsInAStringWithoutUsingBuildInFunction("Hello World");
Console.WriteLine( reverse.ReverseStringRecursively("Hello World"));
reverse.ReverseFileContent(@"C:\\Users\\Hp\\test.txt");
Console.WriteLine (reverse.ReverseEveryKCharacters("Hello World",4));
reverse.ReverseCharArray(['a', 'b', 'c','d','e']);
//ehll o