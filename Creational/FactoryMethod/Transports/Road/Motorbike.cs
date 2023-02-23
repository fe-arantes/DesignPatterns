using FactoryMethod.Interfaces;

namespace FactoryMethod.Transports.Road;

public class Motorbike : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Small Box");
        Console.WriteLine("Motorbike Delivery");
    }
}
