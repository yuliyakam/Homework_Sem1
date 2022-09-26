// Задать прямоугольный двумерный массив. Программа выводит номер 
// строки с наименьшей суммой элементов

// Считываем данные 
int ReadData(string line)
{   
    Console.WriteLine(line);    
    int x1= int.Parse(Console.ReadLine() ?? "0");    
    return x1;  
}
// Универсальный метода генерации и заполнения двумерного массива
int [,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{   
    System.Random numSintezator = new System.Random();
    // Создаем массив
    int[,] array2D = new int[countRow,countColumn];       
        for (int i = 0; i < countRow; i++)
        {    
            for (int j = 0; j < countColumn ; j++)
            {
            array2D[i,j] = numSintezator.Next(downBorder, topBorder + 1);
            }             
        }    
return array2D;
}
//Печатаем двумерный массив
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
//Выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}
//Нахождение строки с наименьшей суммой элементов и фиксация индекса этой строки
int FindMinRow(int[,] array)
{
    int outIndexRow = 1;
    int min = int.MaxValue;
    int sum = 0;    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)      
            {
            sum += array[i,j];
            }           
        if (min > sum) 
        {            
            min = sum;        
            outIndexRow = i;     
        }
        sum = 0;
    }   
    return outIndexRow;
}

int row = ReadData("Введите кол.строк ");
int col = ReadData("Введите кол.столб ");
int [,] arr2D = Fill2DArray(row, col, 0, 9);
Print2DArray(arr2D);
PrintResult("Индекс строки с наименьшей суммой элементов = " + FindMinRow(arr2D));