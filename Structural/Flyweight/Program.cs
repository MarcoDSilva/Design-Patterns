using Structural.Flyweight.Services.Factories;
using Structural.Flyweight.Services.Models;

var bullets = new BulletFactory();
var firstSpaceship = new Spaceship(bullets.GetBullet("bomb"));
var secondSpaceship = new Spaceship(bullets.GetBullet("bomb"));

firstSpaceship.Shoot(30,50);
secondSpaceship.Shoot(24,66);