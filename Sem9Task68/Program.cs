// Программа вычисления функции Аккермана с помощью рекурсии

//Считываем данные 
int ReadData(string line)
{   
    Console.Write(line);   
    //Считываем число и преобразуем из строки в int
    int x1= int.Parse(Console.ReadLine() ?? "0"); 
    //Возвращаем значение
    return x1;  
}
//Выводим результат
void PrintResult (string line)
{
    Console.WriteLine(line);
}
// Вычисление функции Аккермана по m, n
int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if((m > 0)&&(n == 0)) 
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else if ((m > 0)&&(n > 0))
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }
    else return n + 1;   
}
int numM = ReadData("Введите число m ");
int numN = ReadData("Введите число n ");
Console.WriteLine(FunctionAkkerman(numM,numN));