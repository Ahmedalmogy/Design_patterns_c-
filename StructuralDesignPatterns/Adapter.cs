namespace StrucuralDesignPatterns.Adapter{
    /*
    The Adapter Pattern allows incompatible interfaces to work together.
     It acts as a bridge between two incompatible interfaces by 
     converting the interface of a class into another interface that a client expects.

    Example: Adapting a legacy system's API to work with a new system.
    */
    // Target interface
public interface ITarget
{
    void Request();
}

// Adaptee class
public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Called SpecificRequest()");
    }
}

// Adapter class
public class Adapter : ITarget
{
    private Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public void Request()
    {
        _adaptee.SpecificRequest();
    }
}

// Client code
class Program
{
    static void Main(string[] args)
    {
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);
        target.Request();
    }
}

}