namespace StrucuralDesignPatterns.decorator{
    /*
    decorator pattern used to attach attaches additional responsibilities to an object dynamically.
    it provides a flexible alternative to subclassing for extending functionality.
    */
    /// <summary>
    /// The Component interface declares an operation for which all concrete components must implement.
    /// In this case, it is a method called Draw().
    /// </summary>
    public abstract class VisualComponent
    {
        public abstract void Draw();
    }

    // Concrete Component
    /// <summary>
    /// The ConcreteComponent class represents the object to which the decorator is attached.
    /// It is the base class for all components and defines the interface for them.
    /// </summary>
    public class TextView : VisualComponent
    {
        /// <summary>
        /// This method is the basic operation that is performed by the component.
        /// In this case, it is a simple draw operation.
        /// </summary>
        public override void Draw()
        {
            Console.WriteLine("Drawing TextView");
        }
    }

    /// <summary>
    /// Decorator is a base abstract class that serves as a wrapper for the component.
    /// It implements the same interface as the component, but delegates the real work to the component.
    /// This allows the decorator to add new behaviors to the component without modifying it.
    /// </summary>
    public abstract class Decorator : VisualComponent
    {
        protected VisualComponent component;

        public Decorator(VisualComponent component)
        {
            this.component = component;
        }

        public override void Draw()
        {
            component.Draw(); // Delegate the real work to the component
        }
    }

    /// <summary>
    /// The BorderDecorator class is a concrete decorator that adds a border to the visual component.
    /// It decorates the TextView class and adds the responsibility of drawing a border.
    /// This class demonstrates how to add new behaviors to the component using the decorator pattern.
    /// </summary>
    public class BorderDecorator : Decorator
    {
        /// <summary>
        /// Constructor for the BorderDecorator class.
        /// It takes a VisualComponent object and sets it as the component of this decorator.
        /// </summary>
        /// <param name="component">The VisualComponent object to decorate.</param>
        public BorderDecorator(VisualComponent component) : base(component) { }

        /// <summary>
        /// This method delegates the real work to the component and then adds the responsibility of drawing a border.
        /// </summary>
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Drawing Border");
        }
    }


    class Program
    {
        // Main method demonstrates the usage of the Decorator pattern
        static void Main(string[] args)
        {
            // Create a TextView component
            VisualComponent textView = new TextView();

            // Create a BorderDecorator decorator that wraps around the TextView component
            VisualComponent borderedTextView = new BorderDecorator(textView);

            // Call the Draw method on the borderedTextView component
            // This will first delegate the real work to the TextView component
            // and then add the responsibility of drawing a border
            borderedTextView.Draw();
        }

    }


}