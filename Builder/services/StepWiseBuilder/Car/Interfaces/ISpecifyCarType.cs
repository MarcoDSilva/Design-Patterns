using Builder.Services.StepWiseBuilder.Car.Enum;

namespace Builder.Services.StepWiseBuilder.Car.Interfaces;

public interface ISpecifyCarType
{
    ISpecifyWheelSize OfType(CarType type);
}
