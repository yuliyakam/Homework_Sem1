/*Программа принимает на вход трехзнач.число, на выходе показывает вторую цифру этого числа*/
Console.WriteLine("Введите трехзначное число");
string? A = Console.ReadLine();
if ( A != null)
{
//Cоздаем массив NumberArray с элементами, котоые получим после преобраз.строч перм А в симв.массив
    char[] NumberArray = A.ToCharArray();
    Console.WriteLine((NumberArray.Length == 3) ? "Вторая цифра числа = "+ NumberArray[1] : 
    "Введенное число не является трехзначным");
}
