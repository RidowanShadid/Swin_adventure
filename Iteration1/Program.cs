using Iteration1;
using System;

    class Program
{
    static void Main()
    {
        // Create an instance of IdentifiableObject with two identifiers
        IdentifiableObject obj = new IdentifiableObject(new string[] { "id1", "id2" });

        // Demonstrate the AreYou method
        Console.WriteLine(obj.AreYou("id1")); // Expected output: True
        Console.WriteLine(obj.AreYou("ID2")); // Expected output: True (case insensitive)
        Console.WriteLine(obj.AreYou("id3")); // Expected output: False

        // Show the first identifier using FirstId
        Console.WriteLine(obj.FirstId); // Expected output: "id1"

        // Add a new identifier and test again
        obj.AddIdentifier("id3");
        Console.WriteLine(obj.AreYou("id3")); // Expected output: True

        // Attempt to add a duplicate identifier (should not duplicate)
        obj.AddIdentifier("id1");

        // Print all identifiers to check duplication
        Console.WriteLine("All identifiers:");
        foreach (var id in obj.GetIdentifiers())
        {
            Console.WriteLine(id);
        }

        // Show usage of FirstId when no identifiers are present
        IdentifiableObject emptyObj = new IdentifiableObject(new string[] { });
        Console.WriteLine($"First identifier of an empty object: '{emptyObj.FirstId}'"); // Expected output: ''

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

