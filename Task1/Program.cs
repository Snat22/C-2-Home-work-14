
using Task1;

var car1 = new Car(0);
car1.Drive();
System.Console.Write("Write number for zapravka vashego avto: ");
car1.Refuel(Convert.ToInt32(Console.ReadLine()));
car1.Drive();