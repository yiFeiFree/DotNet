// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
Basic.CalNum();
Basic.TestOper();
Basic.TypeConverter();
System.Console.WriteLine(Basic.FindMax(1,2));
int a=1;
Basic.ParamRef(ref a);
System.Console.WriteLine(a);
int b;
double c=Basic.ParamOut(a,out b);
System.Console.WriteLine(b+" "+c);

Basic.TestSwitchAndModenMatch();
Basic.TestWhile();
Basic.TestFor();
Basic.Array();
Basic.TestArrayList();

Person person=new Person();
person.Name="yifei";
person.Age=18;

Person person=new Person("yifei",18);
person.Name="yifei";

person.Eat();
System.Console.WriteLine();
Person person2=person;
System.Console.WriteLine(object.ReferenceEquals(person,person2));
*/

Cat cat=new Cat();
cat.Name="kity";
cat.Age=2;
cat.Run();
cat.Roar();

Cat cat2=new Cat("kite",3);
cat2.Run();
cat2.Roar();

Animal animal=new Cat("he",3);
animal.Roar();

