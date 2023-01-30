using Structural.Flyweight.Services.Interfaces;
using Structural.Flyweight.Services.Models;

namespace Structural.Flyweight.Services.Factories;

public class BulletFactory
{
    private Dictionary<string, IBullet> _bullets = new Dictionary<string, IBullet>();

    public IBullet GetBullet(string key)
    {
        if (_bullets.ContainsKey(key))
        {
            System.Console.WriteLine("bullet found, pointer given");
            return _bullets[key];
        }
        else 
        {
            IBullet bullet = new ConcreteBullet();
            _bullets[key] = bullet;
            return bullet;
        }
    }
}