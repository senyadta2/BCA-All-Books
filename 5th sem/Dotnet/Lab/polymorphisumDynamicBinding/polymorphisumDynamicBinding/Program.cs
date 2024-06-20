
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal Makkes a sound");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog Says Woof");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat Says meow");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Animal mypet;
        Random ran = new Random();
        int val = ran.Next(0,2);
        Console.WriteLine(val);
        if(val == 0)
        {
            mypet = new Dog();
        }
        else
        {
            mypet = new Cat();
        }
        mypet.Speak();


    }
}