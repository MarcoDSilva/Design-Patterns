using Builder.Services.StepWiseBuilder.Car.Enum;
namespace Builder.Services.StepWiseBuilder.Car;

public class Car
{
    public CarType Type;
    public int WheelSize;

    public override string ToString()
    {
        return $"Car is of the type: {Type} with the wheel size of: {WheelSize}";
    }
}