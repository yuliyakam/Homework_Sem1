// Программа принимает индекс элемента и выводит его, если такого элемента нет, 
// то сообщает об этом

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
{   //Генератор случайных чисел
    System.Random numSintezator = new System.Random();
    //Создаем массив
    int[,] array2D = new int[countRow,countColumn];
    //Тест границ
    if (downBorder < topBorder)
    { //Заполнение массива
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
// Нахождение элемента по индексу
int FindElement(int row, int column, int[,] array2D)
{
    if ((row < array2D.GetLength(0))&&(column < array2D.GetLength(1)))
    {
        return array2D[row,column];
    }
    else
    {
        return  -1;        
    }
}
// Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);    
}

int row = ReadData("Введите количество строк ");
int col = ReadData("Введите количество столбцов ");
int downBorder = ReadData("Введите нижнюю границу массивва: ");
int topBorder = ReadData("Введите верхнюю границу массивва: ");
int [,] arr2D = Fill2DArray(row, col, downBorder, topBorder);
Print2DArray(arr2D);
int x = ReadData("Введите номер строки ");
int y = ReadData("Введите номер столбца ");
PrintResult((FindElement(x,y,arr2D) == -1) ? "Элемента с таким индексом" +
" в данном массиве нет" : ("Искомый элемент: " + FindElement(x,y,arr2D)));
