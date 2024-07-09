// the builder pattern code use  

using CreationalDesignPatterns;
  // Create a GamingComputerBuilder instance
        IComputerBuilder builder = new GamingComputerBuilder();
        
        // Create a Director and construct the computer
        Director director = new Director(builder);
        director.Construct();
        
        // Get the constructed computer
        Computer gamingComputer = builder.GetComputer();
        
        // Display the details of the computer
        Console.WriteLine(gamingComputer);