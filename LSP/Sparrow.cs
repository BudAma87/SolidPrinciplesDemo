namespace LSP;
public class Sparrow : Bird, IFlyable
{
    public override void Eat() => Console.WriteLine("Sparrow eating");
    public void Fly() => Console.WriteLine("Sparrow flying");
}