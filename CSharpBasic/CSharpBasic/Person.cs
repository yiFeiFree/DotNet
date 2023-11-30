using System.Dynamic;

public class Person
{
    public Person()
    {

    }
    public Person(string name, int age)
    {
        this.name = name;
    }

    private string name;
    private DateTime birthDay;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age => DateTime.Now.Year - birthDay.Year;

    public void Eat()
    {
        System.Console.WriteLine(name + " is eating...");
    }

}