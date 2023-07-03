﻿string input;

while ((input = Console.ReadLine()) != "END")
{
    if (int.TryParse(input, out int numberInt))
    {
        Console.WriteLine($"{input} is integer type");
    }
    else if (float.TryParse(input, out float numberFloat))
    {
        Console.WriteLine($"{input} is floating point type");
    }
    else if (char.TryParse(input, out char symbol))
    {
        Console.WriteLine($"{input} is character type");
    }
    else if (bool.TryParse(input, out Boolean value))
    {
        Console.WriteLine($"{input} is boolean type");
    }
    else
    {
        Console.WriteLine($"{input} is string type");
    }
}