//Non Fluent Builder
using Builder.Services.StepWiseBuilder.Car;
using Builder.Services.HTML;
using Builder.Services.StepWiseBuilder.Car.Enum;
using Builder.Services.FunctionalBuilder;

var builder = new HtmlBuilder("ul");

builder.AddChild("li", "first child");
builder.AddChild("li", "second child");
System.Console.WriteLine(builder.ToString());

// Fluent Builder
builder.Clear();
builder
    .AddChildFluent("li", "first")
    .AddChildFluent("li", "second")
    .AddChildFluent("li", "third");

System.Console.WriteLine(builder);

//stepwise builder
var car = CarBuilder
            .Create()
            .OfType(CarType.Crossover)
            .WithWheels(19)
            .Build();

System.Console.WriteLine(car);

//functional builder
var personBuilder = new PersonBuilder();
var person = personBuilder
                .Called("Juan")
                .WorksAs("Musqueeter")
                .Build();

System.Console.WriteLine(person);