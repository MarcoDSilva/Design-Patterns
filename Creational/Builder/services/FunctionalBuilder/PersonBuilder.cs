namespace Builder.Services.FunctionalBuilder;

public sealed class PersonBuilder
{
    public readonly List<Action<Person>> Actions = new List<Action<Person>>();

    public PersonBuilder Called(string name)
    {
        Actions.Add(p => { p.Name = name; });
        return this;
    }

    public Person Build()
    {
        var p = new Person();
        Actions.ForEach(act => act(p));
        return p;
    }
}