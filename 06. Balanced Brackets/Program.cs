int n = int.Parse(Console.ReadLine());
int openingBrackets = 0;
int closingBrackets = 0;
string lastString = "";
bool flag = false;

for (int i = 1; i <= n; i++)
{
    string currentString = Console.ReadLine();

    if (currentString == lastString)
    {
        flag = true;
    }

    if (currentString == "(")
    {
        openingBrackets++;
    }
    else if (currentString == ")")
    {
        closingBrackets++;
    }

    if (currentString == "(" || currentString == ")")
    {
        lastString = currentString;
    }
}

if (flag || openingBrackets != closingBrackets)
{
    Console.WriteLine("UNBALANCED");
}
else
{
    Console.WriteLine("BALANCED");
}