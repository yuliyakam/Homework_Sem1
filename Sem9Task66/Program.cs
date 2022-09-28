// Задать M N, найти сумму натур чис от  M до N

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
//Вывод элементов от М до N
string RecLine(int M, int N)
{// Точка выхода
    if (M >= N+1) return "";
    return M + " " + RecLine(M + 1, N);
}
//Вывод суммы элементов от М до N
int RecSum(int M, int N)
{// Точка выхода
    if (M >= N+1) return 0;
    return M + RecSum(M + 1, N);
}

int numM = ReadData("Введите число M ");
int numN = ReadData("Введите число N ");
if (numM < numN) 
{
    Console.WriteLine(RecLine(numM,numN));
    PrintResult("Сумма элементов от М до N = " + RecSum(numM,numN));
}
else 
{
    Console.WriteLine(RecLine(numN,numM));
    PrintResult("Сумма элементов от N до М = " + RecSum(numN,numM));
}
