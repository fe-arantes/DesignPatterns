using FactoryMethod.Interfaces;

namespace FactoryMethod.Transports.Road;

public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Large Box");
        Console.WriteLine("Truck Delivery");
    }
}
