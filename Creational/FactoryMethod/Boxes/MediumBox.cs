using FactoryMethod.Enums;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Boxes;

public class MediumBox : IBox
{
    public SizeEnum Size => SizeEnum.Medium;
}
