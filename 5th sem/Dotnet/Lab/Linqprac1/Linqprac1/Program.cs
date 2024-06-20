/*class student
{
    public int id;
    public String name;
    public String address;
    public student(int id, String name , String address)
    {
        this.id = id;
        this.name = name;
        this.address = address;
    }
}
class Linqeg
{
    public static void Main(String[] args)
    {
        List<student> studentlist = new List<student>()
        {
            new student(1,"ravi","kalimati"),
            new student(2,"sita","chagal")
        };
        var result = studentlist.Where(s => s.name == "ravi").OrderBy(s => s.name);
        foreach(var i in result)
        {
            Console.WriteLine(i.name + " & "  + i.address);
        }
    }
}*/