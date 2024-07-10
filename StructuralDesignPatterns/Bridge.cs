namespace StrucuralDesignPatterns.Adapter{
    /// <summary>
    /// This abstract class represents the abstraction part of the bridge pattern.
    /// It is the 'Abstraction' in the pattern.
    /// The RemoteControl class is responsible for controlling the device using the abstraction.
    /// </summary>
    public abstract class RemoteControl{
        protected IDevice Device;

        /// <summary>
        /// Constructor of the RemoteControl class.
        /// It initializes the device to be controlled using the 'this' keyword.
        /// The 'this' keyword refers to the current instance of the class (RemoteControl).
        /// It is used to access the current instance of the class within the constructor.
        /// </summary>
        /// <param name="device">The device to be controlled</param>
        public RemoteControl(IDevice device){
          this.Device  = device;
        }

        /// <summary>
        /// Method to turn on the device.
        /// This method is abstract and must be implemented in the concrete RemoteControl classes.
        /// </summary>
        public abstract void TurnOn();

        /// <summary>
        /// Method to turn off the device.
        /// This method is abstract and must be implemented in the concrete RemoteControl classes.
        /// </summary>
        public abstract void TurnOff();
    }

    /// <summary>
    /// This interface represents the 'Implementor' in the Bridge pattern.
    /// It defines the methods that the abstraction can call to perform operations on the device.
    /// The abstraction does not depend on the implementation of the device, but it delegates the
    /// responsibility to the 'Implementor' interface.
    /// </summary>
    public interface IDevice{
        /// <summary>
        /// Method to turn on the device.
        /// This method is implemented by the concrete devices and is called by the abstraction.
        /// </summary>
        void TurnOn();

        /// <summary>
        /// Method to turn off the device.
        /// This method is implemented by the concrete devices and is called by the abstraction.
        /// </summary>
        void TurnOff();
    }


    /// <summary>
    /// This class represents a concrete device that implements the IDevice interface.
    /// It is used by the RemoteControl abstraction to control the device.
    /// 
    /// This class is part of the Bridge design pattern.
    /// </summary>
    public class TV : IDevice{
        /// <summary>
        /// Method to turn on the TV.
        /// This method is called by the RemoteControl abstraction to control the device.
        /// </summary>
        public void TurnOn(){
            Console.WriteLine("TV turned on");
        }
        /// <summary>
        /// Method to turn off the TV.
        /// This method is called by the RemoteControl abstraction to control the device.
        /// </summary>
        public void TurnOff(){
            Console.WriteLine("TV turned off");
        }
}



/// <summary>
/// This class represents the concrete implementation of the RemoteControl abstraction using the TV device.
/// It is part of the Bridge design pattern.
/// 
/// The RemoteControl abstraction is responsible for controlling the device using the abstraction.
/// The concrete implementation of the abstraction is the TVRemoteControl class, which uses the TV device.
/// The TVRemoteControl class delegates the responsibility of turning on and off the device to the TV device
/// by calling its respective methods.
/// </summary>
public class TVRemoteControl : RemoteControl
{
    public TVRemoteControl(IDevice device) : base(device) { }

    public override void TurnOn()
    {
        device.TurnOn();
    }

    public override void TurnOff()
    {
        device.TurnOff();
    }
}

}


