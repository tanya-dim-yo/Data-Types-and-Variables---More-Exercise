int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    string myString = Console.ReadLine();
    string[] result = myString.Split(' ', 2);

    long result1 = long.Parse(result[0]);
    long result2 = long.Parse(result[1]);

    long biggerNumber = result2;

    if (result1 > result2)
    {
        biggerNumber = result1;
    }

    long sumOfDigits = 0;

    while (biggerNumber != 0)
    {
        sumOfDigits += biggerNumber % 10;
        biggerNumber /= 10;
    }

    Console.WriteLine(Math.Abs(sumOfDigits));
}