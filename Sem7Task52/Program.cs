// Cоздать двумерный массив и посчитать ср.ариф в каждом столбце

// Считываем данные 
int ReadData(string line)
{   
    Console.WriteLine(line);   
    // Считываем число и преобразуем из строки в int
    int x1= int.Parse(Console.ReadLine() ?? "0"); 
    // Возвращаем значение
    return x1;  
}
// Универсальный метода генерации и заполнения двумерного массива
int [,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{   // Генератор случайных чисел
    System.Random numSintezator = new System.Random();
    // Создаем массив
    int[,] array2D = new int[countRow,countColumn];
    // Тест границ
    if (downBorder < topBorder)
    { // Заполнение массива
        for (int i = 0; i < countRow; i++)
        {    
            for (int j = 0; j < countColumn ; j++)
            {
                array2D[i,j] = numSintezator.Next(downBorder, topBorder + 1);
            }
            
        }
    } 
return array2D;
}
// Печатаем двумерный массив
void Print2DArray( int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();        
    }   
}
// Печатаем одномерный массив
void Print1DArray( double[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.WriteLine(array[array.Length-1]);
}
// Вычисляем среднее арифметическое
double[] Count(int[,] arr2D)
{
    double[] array = new double[arr2D.GetLength(1)];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            array[j] = array[j] + arr2D[i,j];
        }
    }
    for (int k = 0; k < arr2D.GetLength(1); k++)
    {
        array[k] = array[k]/((double)arr2D.GetLength(0));
    }
    return array;
}

int row = ReadData("Введите кол.строк ");
int col = ReadData("Введите кол.столб ");
int downBorder = ReadData("Введите нижнюю границу массивва: ");
int topBorder = ReadData("Введите верхнюю границу массивва: ");
int [,] arr2D = Fill2DArray(row, col, downBorder, topBorder);
Print2DArray(arr2D);
Console.WriteLine();
Print1DArray(Count(arr2D));
