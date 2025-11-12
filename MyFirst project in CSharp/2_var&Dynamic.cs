using System;

class VarAndDynamic
{
    static void Main()
    {
        // Normal typed variables (type fixed, cannot change)
        int number = 10;
        number = number + 1;
        Console.WriteLine(number); 

        string name = "Csharp";
        name = ".netCore fullstack development";
        Console.WriteLine("String name: " + name);

        double price = 12.987;
        price = 11.098;
        Console.WriteLine("Double price: " + price);

        // Var variable (type inferred from first assignment and fixed after)
        var someValue = 10;
        someValue = 20;
        Console.WriteLine("Var someValue (int): " + someValue);

        var someText = "Hello";
        Console.WriteLine("Var someText (string): " + someText);

        var someBool = true;
        Console.WriteLine("Var someBool (bool): " + someBool);

        // Dynamic variable (type can change at runtime)
        dynamic dynValue = 10;
        Console.WriteLine("Dynamic initial value: " + dynValue); 

        dynValue = "Changed to string";
        Console.WriteLine("Dynamic changed to string: " + dynValue);

        dynValue = false;
        Console.WriteLine(dynValue);
    }
}
