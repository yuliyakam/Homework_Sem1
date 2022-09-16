// В массиве из вещественных(double) чисел найти разницу между max и min элементом

//Считываем данные 
int ReadData(string line)
{   
    Console.WriteLine(line);   
    //Считываем число и преобразуем из строки в int
    int x1= int.Parse(Console.ReadLine() ?? "0"); 
    //Возвращаем значение
    return x1;  
}
//Метод генерации и заполнения массива вещественными числами
double [] FillArray(int num)
{   //Генератор случайных чисел
    Random numSintezator = new Random();
    //Создаем массив
    double[] array = new double[num];
    
           for (int i = 0; i < array.Length; i++)
           {
                array[i] = numSintezator.NextDouble();
           } 
return array;
}
//Печатаем одномерный массив
void Print1DArray( double[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length-1]);
}
//Метод нахождения max и min и разницы между ними
double MinMax(double[] array)
{
    double max = double.MinValue;//array[0];
    double min = double.MaxValue;//array[0];    
    foreach (double item in array )
    {
        if (item > max)
        {
            max = item;
        }
       
        if (item < min)
        {
            min = item;
        }      
    }
    Console.WriteLine("макс " + max);
    Console.WriteLine("мин " + min);
    return (max-min);
}
//Выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrayLen = ReadData("Введите длину массива: ");
double[] Array = FillArray(arrayLen);
Print1DArray(Array);
PrintResult("Разница между max и min элементом = " + MinMax(Array));
