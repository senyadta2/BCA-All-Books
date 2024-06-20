class program
{
    public delegate void myDelegate(int x, int y);
    static void add(int x, int y)
    {
        Console.WriteLine(x + y);
    }
    static void sub(int x , int y) { 
    Console.WriteLine(x - y);
    }
    public static void Main(string[] args)
    {
        myDelegate del = new myDelegate(add);
        del += sub;
        del(1,1 );
        

    }
}