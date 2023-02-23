using FactoryMethod.Enums;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Boxes;

public class LargeBox : IBox
{
    public SizeEnum Size => SizeEnum.Large;
}
