using FactoryMethod.Enums;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Boxes;

public class SmallBox : IBox
{
    public SizeEnum Size => SizeEnum.Small;
}
