namespace Builder.Services.StepWiseBuilder.Car.Interfaces;

public interface ISpecifyWheelSize
{
    IBuildCar WithWheels(int size);
}
