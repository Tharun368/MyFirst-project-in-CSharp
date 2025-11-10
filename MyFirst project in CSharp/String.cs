using System;

class EnhancedStringExample
{
    static void Main()
    {
        // Basic string declaration and use
        string courseName = "Csharp Programming";
        Console.WriteLine(courseName);

        // String with escaped quotes
        string quotedCourseName = "\"Csharp Programming\"";
        Console.WriteLine(quotedCourseName);

        // Multiline string using \n and verbatim string with line breaks
        string listStatus = "Step 1: Start\nStep 2: Code\nStep 3: Test";
        Console.WriteLine(listStatus);

        string verbatimListStatus = @"Step 1: Start
Step 2: Code
Step 3: Test";
        Console.WriteLine(verbatimListStatus);

        // File path examples — double backslash and verbatim string
        string projectPath = "D:\\Csharp_Nov\\MyConsoleApp";
        Console.WriteLine(projectPath);

        string projectPathVerbatim = @"D:\Csharp_Nov\MyConsoleApp";
        Console.WriteLine(projectPathVerbatim);

        // String interpolation with different variable types
        string studentName = "Mary";
        int age = 15;
        double grade = 88.5;

        string studentDetails = $"Name: {studentName}, Age: {age}, Grade: {grade:F1}%";
        Console.WriteLine(studentDetails);

        // String concatenation example
        string greeting = "Hello, ";
        string fullGreeting = greeting + studentName + "!";
        Console.WriteLine(fullGreeting);

        // String methods demonstration
        string upperCourse = courseName.ToUpper();
        string lowerCourse = courseName.ToLower();

        Console.WriteLine($"Uppercase: {upperCourse}");
        Console.WriteLine($"Lowercase: {lowerCourse}");

        // Replace part of string
        string replacedCourse = courseName.Replace("Programming", "Language");
        Console.WriteLine(replacedCourse);
    }
}
