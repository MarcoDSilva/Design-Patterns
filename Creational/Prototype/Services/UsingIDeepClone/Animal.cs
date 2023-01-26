namespace Prototype.Services.UsingIDeepClone;

public abstract class Animal : ICloneable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Owner Owner { get; set; }
    public abstract object Clone();
    public abstract object DeepClone();
}