namespace Howest.MCT.Exercise05.Models;

public interface IVehicle
{
    void Drive();
}

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a car");
    }
}

public class Truck : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a truck");
    }
}

public class Motorcycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a motorcycle");
    }
}