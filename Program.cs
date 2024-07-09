// See https://aka.ms/new-console-template for more information

using Design_patterns_c_;
 TextDocument originalDoc = new TextDocument { Content = "Hello, World!" };
        
        // Use the copy constructor to create a new instance
        TextDocument copiedDoc = new TextDocument(originalDoc);
        copiedDoc.Content = "Hello, Copy Constructor!";
        
        // Print original and copied documents
        originalDoc.Print(); // Output: TextDocument: Hello, World!
        copiedDoc.Print();   // Output: TextDocument: Hello, Copy Constructor!
