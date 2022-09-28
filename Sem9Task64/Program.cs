// Программа принимает число N и выводит числа от N до 1

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
// Выводим числа от N до 1
string LineGenRec(int numN)
{
    // Точка остановки     
    if (numN==0) return "";
    string outLine = numN + " " + LineGenRec(numN - 1);
    return outLine;
}

int num = ReadData("Введите число N ");
string resuiltLine = LineGenRec(num);
PrintResult(resuiltLine);