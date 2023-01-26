namespace Prototype.Services.UsingIDeepClone;

public class Dog : Animal
{
    public string Color { get; set; }

    public override object Clone()
    {
        return (Animal)this.MemberwiseClone(); // this is a shallow copy, so be careful 
    }

    public override object DeepClone()
    {
        Animal clone = (Animal)this.MemberwiseClone();
        clone.Owner = new Owner();
        clone.Owner.Adress = clone.Owner.Adress;
        clone.Owner.Name = clone.Owner.Name;
        return clone;
    }

    public override string ToString()
    {
        return $"Animal ID: {this.Id}, Name: {this.Name}, Owner name: {this.Owner.Name}, Owner Address: {this.Owner.Adress}, Color {this.Color}";
    }
}