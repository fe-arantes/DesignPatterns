using FactoryMethod.Transports.Sea;
using FactoryMethod.Factories.Standard;
using FactoryMethod.Interfaces;
using FactoryMethod.Enums;
using FactoryMethod.Transports.Road;

namespace FactoryMethod.Factories;

public class SeaFactory : LogisticsFactory
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}
