double number1 = double.Parse(Console.ReadLine());
double number2 = double.Parse(Console.ReadLine());
double eps = 0.000001;

double difference = Math.Abs(number1 - number2);

if (difference >= eps)
{
    Console.WriteLine("False");
}
else
{
    Console.WriteLine("True");
}