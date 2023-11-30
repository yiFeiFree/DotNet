public class Cat:Animal{
    public Cat(){

    }

    public Cat(string name,int age):base(name,age){

    }
    public void Run(){
        System.Console.WriteLine("cat is running...");
    }
    public override void Roar(){
        // base.Roar();
        System.Console.WriteLine($"cat {Name} is roaring");
    }

    public override void Eat()
    {
        System.Console.WriteLine($"cat {Name} is eating");
    }
}