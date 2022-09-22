//Сколько чисел больше 0 с клавиатуры ввел пользователь
//Считываем данные, для ввода вещественных.чисел используем тип данных double
double ReadData(string line)
{   
    Console.Write(line);   
    //Считываем число и преобразуем из строки в double
    double x1= double.Parse(Console.ReadLine() ?? "0"); 
    //Возвращаем значение
    return x1;  
}
//Анализ чисел на положительность и подсчет тех, что >0
int Count(double num)
{
    int res = 0;
    for (int i = 0; i < num; i++)
    {
        double number = ReadData("");
        if (number>0)
        {
            res++;
        }        
    }
    return res;
}
//Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

double countNumber = ReadData("Введите планируемое для анализа на положительность количество чисел ");
Console.WriteLine("Вводите числа по одному и нажимайте Enter");
PrintResult("Количество введенных положительных чисел = " + Count(countNumber));
