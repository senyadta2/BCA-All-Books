using System;
class linq_eg
{

    
    public static void Main(string[] args)
    {
        string[] strarr = { "first", "second", "third", "fourth" };
        var linq = from name in strarr where name.Contains('i') | name.Contains('f') select name;
        foreach(var item in linq)
        {
            Console.WriteLine(item);
        }
    }
    
}