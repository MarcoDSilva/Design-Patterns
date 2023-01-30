using Structural.Flyweight.Services.Interfaces;

namespace Structural.Flyweight.Services.Models;

public class ConcreteBullet : IBullet
{
    public void Draw(int x, int y)
    {
        System.Console.WriteLine($"Shooting bullet at {x}, {y}");
    }
}