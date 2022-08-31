//==================================================================
// Программа, которая принимает на вход числo  и выдает является ли
// число четным
//==================================================================
Console.Write("Введите число ");
string? Number = Console.ReadLine();
if (Number != null)
{   int YourNumber = int.Parse(Number);
    int mod = YourNumber % 2;
    if (mod == 0)
    {
        Console.WriteLine("Введенное число четное");
    }
    else
    {
        Console.WriteLine("Введенное число нечетное");
    }
}