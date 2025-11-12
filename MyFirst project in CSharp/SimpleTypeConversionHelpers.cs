using System;

internal static class SimpleTypeConversionHelpers
{
    private const int V = 10;

    static void Main()
    {
        // Implicit Conversion
        byte smallNumber = V;
        int biggerNumber = smallNumber;
        Console.WriteLine("Implicit Conversion: " + biggerNumber);

        // Explicit Conversion (you have to tell compiler to convert)
        double bigValue = 9.99;
        int smallValue = (int)bigValue;
        Console.WriteLine("Explicit Conversion: " + smallValue);

        // Boxing  (reference type)
        int number = 100;
        object boxedNumber = number;
        Console.WriteLine("Boxing: " + boxedNumber);

        // Unboxing
        int unboxedNumber = (int)boxedNumber;  // unboxing here
        Console.WriteLine("Unboxing: " + unboxedNumber);

        // Strings 
        string name1 = "Hello";
        string name2 = name1;  // both are same text
        Console.WriteLine("Before change: name1 = " + name1 + ", name2 = " + name2);

        name2 = "World";  // name2 are different text
        Console.WriteLine("After change: name1 = " + name1 + ", name2 = " + name2);
    }
}