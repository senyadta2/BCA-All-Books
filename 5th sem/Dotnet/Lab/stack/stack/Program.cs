class program
{
    public static void Main(string[] args)
    {
        Stack<String> stack1 = new Stack<String> ();
        stack1.Push ("a");
        stack1.Push ("b");
        stack1.Push ("c");

        foreach(string a in stack1)
        {
            Console.WriteLine (a);
        }

    }
}