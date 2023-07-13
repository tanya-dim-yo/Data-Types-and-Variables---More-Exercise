int key = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
char[] decryptedChars = new char[n];

for (int i = 0; i < n; i++)
{
    char currentCharacter = char.Parse(Console.ReadLine());
    int decryptedCharInt = (int)(currentCharacter) + key;
    char decryptedChar = (char)decryptedCharInt;
    decryptedChars[i] = decryptedChar;
}

for (int index = 0; index < decryptedChars.Length; index++)
{
    Console.Write(decryptedChars[index]);
}