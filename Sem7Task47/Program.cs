// Задача генерации двумерного массива, заполненного случайными вещественными числ

// Считываем данные 
int ReadData(string line)
{   
    Console.WriteLine(line);   
    // Считываем число и преобразуем из строки в double
    int x1= int.Parse(Console.ReadLine() ?? "0"); 
    // Возвращаем значение
    return x1;  
}
// Универсальный метода генерации и заполнения двумерного массива веществ.числами
double [,] Fill2DArrayDoubleNumber(int countRow, int countColumn, int downBorder, int topBorder)
{   
    // Генератор случайных чисел
    Random numSdoubleezator = new Random();
    // Создаем массив
    double[,] array2D = new double[countRow,countColumn];
     // Заполнение массива
        for (int i = 0; i < countRow; i++)
        {    
            for (int j = 0; j < countColumn ; j++)
            {// Для заполнения массива запрашиваем вещественные числа NextDouble()
                array2D[i,j] = numSdoubleezator.Next(downBorder, topBorder + 1) + 
                numSdoubleezator.NextDouble();
            }            
        }    
return array2D;
}
// Печатаем двумерный массив
void Print2DArray( double[,] array)
{
    ConsoleColor[] color = new ConsoleColor[]
        { ConsoleColor.DarkGreen, ConsoleColor.DarkRed, ConsoleColor.DarkMagenta, 
        ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.DarkGray, ConsoleColor.Blue,
        ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.Red, ConsoleColor.Magenta,
        ConsoleColor.Yellow, ConsoleColor.White           
        };
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {// Вещественные числа выдаем с округлением до 2 знаков после зпт Math.Round            
                Console.ForegroundColor = color[new System.Random().Next(0, 12)];
                Console.Write($"{Math.Round(array[i,j],2)} ");               
            }
            Console.ResetColor();
            Console.WriteLine();                    
        }           
}

int row = ReadData("Введите количество строк ");
int col = ReadData("Введите количество столбцов ");
int downBorder = ReadData("Введите нижнюю границу массивва: ");
int topBorder = ReadData("Введите верхнюю границу массивва: ");
double [,] arr2D = Fill2DArrayDoubleNumber(row, col, downBorder, topBorder);
Print2DArray(arr2D);
