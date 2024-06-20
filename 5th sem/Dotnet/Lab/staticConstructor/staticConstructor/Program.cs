class program
{
    public int x;
    static program()
    {
        Console.WriteLine("Static Constuctor called");
    }
    public program(int x) {
        this.x = x;
    }
    public void value ()
    {
        Console.WriteLine(x);
    }

    public static void Main(string [] arg)
    {
        program p = new program(5);
        
        p.value();
    }
}