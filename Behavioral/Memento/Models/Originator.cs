public class Originator
{
    private string state;

    public void SetState(string state)
    {
        Console.WriteLine("Originator: Setting state to " + state);
        this.state = state;
    }

    public Memento SaveStateToMemento()
    {
        Console.WriteLine("Originator: Saving to Memento.");
        return new Memento(state);
    }

    public void RestoreStateFromMemento(Memento memento)
    {
        state = memento.GetState();
        Console.WriteLine("Originator: State after restoring from Memento: " + state);
    }

    public string GetState()
    {
        return state;
    }
}