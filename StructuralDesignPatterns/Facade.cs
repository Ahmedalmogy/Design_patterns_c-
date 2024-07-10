namespace StrucuralDesignPatterns.Facade{
    /// <summary>
    /// The Facade design pattern provides a simplified interface to a complex subsystem of classes.
    /// This allows the client code to interact with the subsystem without having to understand the details of the subsystem itself.
    /// The Facade class acts as a high-level interface to the subsystem, providing a single point of entry for the client code.
    /// </summary>

    // Subsystem classes
    // These are the classes that make up the subsystem.
    // They are responsible for performing specific tasks.
    public class SubsystemA
    {
        public void OperationA()
        {
            Console.WriteLine("Operation A");
        }
    }

    public class SubsystemB
    {
        public void OperationB()
        {
            Console.WriteLine("Operation B");
        }
    }

    // Facade
    // This class acts as a high-level interface to the subsystem.
    // It provides a single point of entry for the client code.
    // The client code can interact with the subsystem through the Facade, without having to understand the details of the subsystem itself.
    public class Facade
    {
        private SubsystemA _subsystemA;
        private SubsystemB _subsystemB;

        public Facade()
        {
            _subsystemA = new SubsystemA();
            _subsystemB = new SubsystemB();
        }

        public void Operation()
        {
            // This method provides a simplified interface to the subsystem.
            // It performs a specific task by calling methods on the subsystem classes.
            _subsystemA.OperationA();
            _subsystemB.OperationB();
        }
    }

    // Client code
    // The client code uses the Facade to interact with the subsystem.
    // The client code does not need to understand the details of the subsystem itself.
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.Operation();
        }
    }

}
