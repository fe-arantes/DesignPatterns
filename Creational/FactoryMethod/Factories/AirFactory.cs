using FactoryMethod.Transports.Air;
using FactoryMethod.Factories.Standard;
using FactoryMethod.Interfaces;


namespace FactoryMethod.Factories;

public class AirFactory : LogisticsFactory
{
    public override ITransport CreateTransport()
    {
        return new Planner();
    }
}
