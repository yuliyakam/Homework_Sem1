//Программа выводит 3 цифру заданного числа или сообщает, что третий цифры нет
Console.WriteLine("Введите число");
string? A = Console.ReadLine();
if ( A != null)
{
    //Cоздаем массив NumberArray с элементами, котоые получим после преобраз.строч перм А в симв.массив
    char[] NumberArray = A.ToCharArray();
    Console.WriteLine((NumberArray.Length < 3) ? "Третьей цифры нет" :
     "Третья цифра " + NumberArray[NumberArray.Length-3]);//Т.к. Введенное число может быть разным 
     //по длине, отчет 3 цифры начнем с конца массива. Первая цифра с конца имеет индекс Length-1
     //соответственно третья - индекс Length-3
}