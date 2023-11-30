public abstract class Animal{
    public Animal(){

    }

    public Animal(string name,int age){
        this.Name=name;
        this.Age=age;
    }

    public string Name {get;set;}
    public int Age {get;set;}

    public virtual void Roar(){
        System.Console.WriteLine($"{Name} is roaring");
    }

    public abstract void Eat();

   
}