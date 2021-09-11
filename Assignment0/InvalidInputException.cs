using System;

public class InvalidInputException : Exception
{
    public InvalidInputException()
    {
    }

    public InvalidInputException(string message)
        : base(message)
    {
        Console.WriteLine(message);
    }
}