namespace StrucuralDesignPatterns.Composite{
    /// the composite pattern allow you to create a tree structure of objects
    /// and perform operations on the entire tree.
    public abstract class FileSystemComponent
{
    public string Name { get; set; }

    public FileSystemComponent(string name)
    {
        Name = name;
    }

    public abstract void Display(int depth);
}


public class File : FileSystemComponent
{
    public File(string name) : base(name) { }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);
    }
}




public class Directory : FileSystemComponent
{
    private List<FileSystemComponent> _components = new List<FileSystemComponent>();

    public Directory(string name) : base(name) { }

    public void Add(FileSystemComponent component)
    {
        _components.Add(component);
    }

    public void Remove(FileSystemComponent component)
    {
        _components.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);

        foreach (var component in _components)
        {
            component.Display(depth + 2);
        }
    }

}
 /// The Composite pattern is a design pattern that allows you to work with objects in a tree-like structure 
    /// as if they were individual objects. This pattern is useful when you need to treat a group of objects in a 
    /// uniform manner, without having to worry about their individual types.
    /// 
   /// The pattern is implemented using a base class called FileSystemComponent, which acts as the 'Component' 
   /// in the pattern. This class declares methods that must be implemented by all concrete components, as well 
    /// as a method to display the component's name.
    /// 
    /// The pattern also includes two concrete components: File and Directory. The File class represents a 
    /// single file, and the Directory class represents a directory. Both classes inherit from the base class 
    /// and implement the methods declared there.
    /// 
   /// The Directory class also includes a List of FileSystemComponent objects, which represents the collection 
    /// of child components. The Directory class also implements the Display method, which recursively calls the 
   /// Display method of all its child components.
   /// 
   /// The benefit of using the Composite pattern is that you can work with individual objects and collections 
   /// of objects in a uniform manner, without having to check their individual types. This makes the code more 
   /// flexible and easier to maintain.
   /// and perform operations on the entire tree.
class Program
{
    static void Main(string[] args)
    {
        Directory root = new Directory("Root");
        root.Add(new File("File1.txt"));
        root.Add(new File("File2.txt"));

        Directory subDir = new Directory("SubDirectory");
        subDir.Add(new File("File3.txt"));
        root.Add(subDir);

        root.Display(1);
    }
}
/// This is an example of how to use the Composite pattern. We create a Directory object called "Root"
      /// and add two File objects to it. We then create another Directory object called "SubDirectory" and add     
       /// a File object to it. We then add the "SubDirectory" object to the "Root" object. Finally, we call the
       /// Display method on the "Root" object to print out the structure of the tree.

}