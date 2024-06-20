class Animal
{
    public virtual void eat()
    {
        Console.WriteLine("Eating");
    }
}

class Dog : Animal
{
    public override void eat()
    {
        Console.WriteLine("Dog is Eating");
    }
}
class puppy : Dog
{
    public override void eat()
    {
        Console.WriteLine("Puppy is eating");
    }
}
class program
{
    public static void Main(string[] args)
    {
        puppy p = new puppy();
        p.eat();
    }
}