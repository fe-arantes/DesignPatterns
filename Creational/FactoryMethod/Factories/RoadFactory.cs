using FactoryMethod.Transports.Road;
using FactoryMethod.Factories.Standard;
using FactoryMethod.Interfaces;
using FactoryMethod.Enums;

namespace FactoryMethod.Factories;

public class RoadFactory : LogisticsFactory
{
    private readonly IBox _box;

    public RoadFactory(IBox box)
    {
        _box = box;
    }

    public override ITransport CreateTransport()
    {
        if ( _box is null )
            throw new NotSupportedException();

        return _box.Size switch
        {
            SizeEnum.Small => new Motorbike(),
            SizeEnum.Medium => new Car(),
            SizeEnum.Large => new Truck(),
            _ => throw new NotSupportedException(),
        };
    }
}
