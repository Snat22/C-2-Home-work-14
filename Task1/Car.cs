namespace Task1;

public class Car : IVehicle
{
    int _gas;

    public Car(int gass)
    {
        _gas = gass;
    }

    public void Drive()
    {
        if (_gas > 0)
        {
                        System.Console.WriteLine("Drive");

        }else
        {
                        System.Console.WriteLine("You need Zapravka");

        }
    }

    public bool Refuel(int gas)
    {
        _gas += gas;
        return true;   
    }
}
