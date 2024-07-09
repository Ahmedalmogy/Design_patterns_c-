
namespace CreationalDesignPatterns{
   /*
   A copy constructor is a special type of constructor in object-oriented programming that initialize
   s a new object as a copy of an existing object. It is commonly used to create a duplicate of an object, 
   ensuring that the new object is a separate instance with the same properties as the original.
   */
    public class TextDocument

{
    public string Content { get; set; }

    // Copy constructor
    public TextDocument(TextDocument original)
    {
        Content = original.Content;
    }

    // Parameterless constructor
    public TextDocument()
    {
    }

    public void Print()
    {
        Console.WriteLine("TextDocument: " + Content);
    }
}
}


