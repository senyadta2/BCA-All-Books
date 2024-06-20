
class Calculate<T>
{
    public T add(T a , T b)
    {
        dynamic Da = a;
        dynamic Db = b;
        return Da + Db;
    }
}

class program 
{
    public static void Main(string[] args)
    {
        Calculate<int> c = new Calculate<int>();
       Console.WriteLine( c.add(1, 1));


    }
}