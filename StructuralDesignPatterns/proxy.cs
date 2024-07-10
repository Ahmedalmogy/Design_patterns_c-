namespace StrucuralDesignPatterns.Proxy{    
/// <summary>
/// The Proxy Pattern is a structural design pattern that provides a surrogate or placeholder for another object to control access to it.
/// It is used to create a representative object that controls access to another object.
/// </summary>

    // Subject
/// <summary>
/// The Subject interface declares a method for executing a request. Any class that implements the Subject interface represents a real subject.
/// </summary>
public interface ISubject
{
    void Request();
}

// RealSubject
/// <summary>
/// The RealSubject class represents the real subject that the Proxy controls access to.
/// </summary>
public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject Request()");
    }
}

// Proxy
/// <summary>
/// The Proxy class represents a proxy object that controls access to the real subject.
/// </summary>
public class Proxy : ISubject
{
    private RealSubject _realSubject;

    /// <summary>
    /// The Proxy class creates an instance of the RealSubject class lazily when the first request is made. 
    /// This is known as lazy initialization. After that, the Proxy class acts as a surrogate for the RealSubject.
    /// </summary>
    public void Request()
    {
        if (_realSubject == null)
        {
            _realSubject = new RealSubject();
        }
        _realSubject.Request();
    }
}

// Client code
/// <summary>
/// The client code works with the Proxy class instead of the RealSubject directly. This allows the client to control access to the RealSubject.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        ISubject proxy = new Proxy();
        proxy.Request();
    }
}

}
