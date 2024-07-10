namespace StrucuralDesignPatterns.Flyweight{

/// <summary>
/// The Flyweight pattern is a structural design pattern that allows you to efficiently use system resources by sharing  
/// as much data as possible. It does this by creating lightweight objects that can be shared across different contexts. 
/// Instead of creating new objects for each context, the Flyweight pattern reuses existing objects and provides a way to 
/// store and retrieve the shared objects.
/// </summary>

// Flyweight
/// <summary>
/// The Character class represents the flyweight object. It stores the intrinsic state of the flyweight object and provides operations 
/// that can be performed on the shared state. The intrinsic state is the data that is unique to each instance of the flyweight object.
/// </summary>
public class Character
{
    private char symbol;
    private int width;
    private int height;

    public Character(char symbol, int width, int height)
    {
        this.symbol = symbol;
        this.width = width;
        this.height = height;
    }

    /// <summary>
    /// The Display method performs an operation on the intrinsic state of the flyweight object and the extrinsic state 
    /// provided by the context.
    /// </summary>
    public void Display(int pointSize)
    {
        Console.WriteLine($"{symbol} (point size {pointSize})");
    }
}

// Flyweight Factory
/// <summary>
/// The CharacterFactory class acts as a factory for creating flyweight objects.
/// It maintains a pool of flyweight objects and retrieves them 
/// from the pool when requested.
/// It checks if the requested flyweight object already exists in the pool and creates a new one if it doesn't.
/// </summary>
public class CharacterFactory
{
    private Dictionary<char, Character> _characters = new Dictionary<char, Character>();

    /// <summary>
    /// The GetCharacter method retrieves a flyweight object from the pool. If the flyweight object doesn't exist in the pool, it creates a new one.
    /// </summary>
    public Character GetCharacter(char symbol)
    {
        if (!_characters.ContainsKey(symbol))
        {
            _characters[symbol] = new Character(symbol, 120, 100);
        }
        return _characters[symbol];
    }
}

// Client code
/// <summary>
/// The Main method demonstrates how the Flyweight pattern can be used.
/// It creates a CharacterFactory object and a document string. 
/// It iterates over the document string and retrieves the corresponding flyweight object from the factory.
/// It then displays the flyweight object 
/// with a point size that increases for each character in the document.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        CharacterFactory factory = new CharacterFactory();

        string document = "AAABBB";
        int pointSize = 10;

        foreach (char c in document)
        {
            Character character = factory.GetCharacter(c);
            character.Display(pointSize);
            pointSize++;
        }
    }
}


}
