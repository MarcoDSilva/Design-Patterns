using Builder.Services.StepWiseBuilder.Car.Interfaces;
using Builder.Services.StepWiseBuilder.Car.Enum;

namespace Builder.Services.StepWiseBuilder.Car;

public class CarBuilder
{
    public static ISpecifyCarType Create()
    {
        return new CarBuildingSequence();
    }

    private class CarBuildingSequence :
        ISpecifyCarType,
        ISpecifyWheelSize,
        IBuildCar
    {
        private Car car = new Car();

        public ISpecifyWheelSize OfType(CarType type)
        {
            car.Type = type;
            return this;
        }

        public IBuildCar WithWheels(int size)
        {
            switch (car.Type)
            {
                case CarType.Crossover when size < 17 || size > 20:
                case CarType.Sedan when size < 15 || size > 17:
                    throw new ArgumentException($"Wrong wheel size for ${car.Type}");
            }
            car.WheelSize = size;
            return this;
        }

        public Car Build()
        {
            return car;
        }
    }
}

