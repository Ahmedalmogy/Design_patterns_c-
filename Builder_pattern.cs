namespace Design_patterns_c_
{
    /*
    The Builder pattern is useful when you need to construct complex objects step by step and want to
     isolate the construction code from the representation.
      A common use case is building a complex Computer object that has multiple components like CPU, RAM, storage, etc.
    */
 //1/define the  product
public class Computer
{
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }
    public string GPU { get; set; }
    public bool HasBluetooth { get; set; }
    public bool HasWiFi { get; set; }

    public override string ToString()
    {
        return $"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, GPU: {GPU}, Bluetooth: {HasBluetooth}, WiFi: {HasWiFi}";
    }
}

//2/define the builder interface with methods to buid differnt parts of the product
public interface IComputerBuilder
{
    void BuildCPU();
    void BuildRAM();
    void BuildStorage();
    void BuildGPU();
    void BuildBluetooth();
    void BuildWiFi();
    Computer GetComputer();
}
//3/define the concrete builder Implement a concrete builder class that builds a specific type of Computer.

public class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void BuildCPU()
    {
        _computer.CPU = "Intel i9";
    }

    public void BuildRAM()
    {
        _computer.RAM = "32GB";
    }

    public void BuildStorage()
    {
        _computer.Storage = "1TB SSD";
    }

    public void BuildGPU()
    {
        _computer.GPU = "NVIDIA RTX 3080";
    }

    public void BuildBluetooth()
    {
        _computer.HasBluetooth = true;
    }

    public void BuildWiFi()
    {
        _computer.HasWiFi = true;
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}
//4 / define the director class that Define a Director class that controls the building process.

public class Director
{
    private IComputerBuilder _builder;

    public Director(IComputerBuilder builder)
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.BuildCPU();
        _builder.BuildRAM();
        _builder.BuildStorage();
        _builder.BuildGPU();
        _builder.BuildBluetooth();
        _builder.BuildWiFi();
    }
}



}