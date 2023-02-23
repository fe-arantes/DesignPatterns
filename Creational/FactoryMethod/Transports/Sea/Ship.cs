using FactoryMethod.Interfaces;

namespace FactoryMethod.Transports.Sea;

public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Sea Delivery");
    }
}
