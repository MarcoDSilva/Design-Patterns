using Factories.Services.FactoryMethod;

//factory method basic example
var cartesianPoint = PointFactory.NewCartesianPoint(1.0, 2.0);
var polarPoint = PointFactory.NewPolarPoint(5.0, 2.5);

Console.WriteLine(cartesianPoint.ToString());
Console.WriteLine(polarPoint.ToString());


