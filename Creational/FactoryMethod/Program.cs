using FactoryMethod.Boxes;
using FactoryMethod.Factories;
using FactoryMethod.Factories.Standard;

Console.WriteLine("My Logistics Factory");

// An array of creators
var logisticsFactory = new LogisticsFactory[]
{
    new RoadFactory(new SmallBox()),
    new RoadFactory(new MediumBox()),
    new RoadFactory(new LargeBox()),
    new SeaFactory(),
    new AirFactory()
};

// Iterate over creators and create products
foreach ( var factory in logisticsFactory )
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Factory: " + factory.GetType().Name);

    var transport = factory.CreateTransport();
    transport.Deliver();
}

// Wait for user
Console.ReadKey();