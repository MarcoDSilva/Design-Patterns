public class Player : ISubject
{
    private List<IObserver> observers;
    private int health;

    public Player()
    {
        observers = new List<IObserver>();
        health = 100;
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyHealthChanged()
    {
        foreach (var observer in observers)
        {
            observer.OnHealthChanged(health);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Console.WriteLine("Player: took " + damage + " damage, current health is " + health);
        NotifyHealthChanged();
    }
}
