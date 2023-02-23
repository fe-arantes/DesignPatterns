using FactoryMethod.Interfaces;

namespace FactoryMethod.Transports.Road;

public class Car : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Medium Box");
        Console.WriteLine("Car Delivery");
    }
}
