public class HealthDisplay : IObserver
{
    public void OnHealthChanged(int newHealth)
    {
        Console.WriteLine("Health display: new health is " + newHealth);
    }
}