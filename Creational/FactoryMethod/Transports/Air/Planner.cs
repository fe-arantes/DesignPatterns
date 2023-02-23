using FactoryMethod.Interfaces;

namespace FactoryMethod.Transports.Air;

public class Planner : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Planner Delivery");
    }
}
