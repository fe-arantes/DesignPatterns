using FactoryMethod.Interfaces;

namespace FactoryMethod.Factories.Standard;

public abstract class LogisticsFactory
{
    public abstract ITransport CreateTransport();
}
