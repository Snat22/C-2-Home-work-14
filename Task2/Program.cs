
using Task2;

var dog1 = new Dog();
System.Console.Write("Dog name: ");
dog1.SetName(Console.ReadLine());

System.Console.WriteLine(dog1.GetName());
dog1.Eat();