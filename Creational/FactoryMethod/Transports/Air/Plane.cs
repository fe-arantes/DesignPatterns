using FactoryMethod.Interfaces;

namespace FactoryMethod.Transports.Air;

public class Plane : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Plane Delivery");
    }
}
