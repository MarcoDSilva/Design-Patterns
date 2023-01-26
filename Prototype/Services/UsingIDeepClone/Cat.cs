namespace Prototype.Services.UsingIDeepClone;

public class Cat : Animal
{
    public string Color { get; set; }

    public override object Clone()
    {
        return (Animal)this.MemberwiseClone(); // this is a shallow copy, so be careful 
    }

    public override string ToString()
    {
        return $"Animal ID: {this.Id}, Name: {this.Name}, Owner name: {this.Owner.Name}, Owner Address: {this.Owner.Adress}, Color {this.Color}";
    }
}