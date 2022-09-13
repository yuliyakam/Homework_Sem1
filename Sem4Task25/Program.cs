//Получаем данные от пользователя
int ReadData(string number)
{   
    Console.WriteLine(number);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}
//1Метод Возводим в степень
long Pow(int numberN, int pow)
{
   long result =(long) Math.Pow(numberN, pow);
    return result;
}
//2Метод Возводим в степень в цикле
long PowInFor(int numberN, int pow)
{   long res = 1;
    for (int i = 1; i <= pow; i++)   
    {
        res = res*numberN;
    }
    return res;
}
//Выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}
int num1 = ReadData("Введите число ");
int num2= ReadData("Введите степень ");

DateTime d1 = DateTime.Now;
PrintResult(num1 + " в степени "+ num2 +" = " + Pow(num1, num2));
Console.WriteLine("1Метод: " + (DateTime.Now - d1));

DateTime d2 = DateTime.Now;
PrintResult(num1 + " в степени "+ num2 +" = " + PowInFor(num1, num2));
Console.WriteLine("2Метод: " + (DateTime.Now - d2));