using System.Security.Cryptography;
using Structural.Decorator.Abstractions;
using Structural.Decorator.Beverage;

Beverage beverage = new Espresso();
System.Console.WriteLine(beverage.Description + ", $" + beverage.Cost());

Beverage other = new Espresso();
other = new Milk(other);
System.Console.WriteLine(other.Description + ", $" + other.Cost());

other = new Whip(other);

System.Console.WriteLine(other.Description + ", $" + other.Cost());
