int number = int.Parse(Console.ReadLine());

for (int i = 2; i <= number; i++)
{
    int ctr = 0;

    for (int j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
        {
            ctr++;
            break;
        }
    }

    if (ctr == 0)
    {
        Console.WriteLine($"{i} -> true");
    }
    else
    {
        Console.WriteLine($"{i} -> false");
    }
}