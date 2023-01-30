using Structural.Flyweight.Services.Interfaces;

namespace Structural.Flyweight.Services.Models;

public class Spaceship
{
    private IBullet _bullet;

    public Spaceship(IBullet bullet)
    {
        _bullet = bullet;
    }

    public void Shoot(int x, int y)
    {
        _bullet.Draw(x,y);
    }

}