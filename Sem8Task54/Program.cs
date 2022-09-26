// Задать двумерный массив и упорядочить элем по убыванию в кажд стр

//Считываем данные 
int ReadData(string line)
{   
    Console.WriteLine(line);    
    int x1= int.Parse(Console.ReadLine() ?? "0");    
    return x1;  
}
//Универсальный метода генерации и заполнения двумерного массива
int [,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{   
    System.Random numSintezator = new System.Random();
    //Создаем массив
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

// Сортируем элементы каждой строки по убыванию
int[,] UpDateArr(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        List<int> pow = new List<int>();
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            pow.Add(arr2D[i,j]);
            pow.Sort();              
        }
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr2D[i,j] = pow[(arr2D.GetLength(1)-j-1)];
        }
    }
    return arr2D;
}

int row = ReadData("Введите кол.строк ");
int col = ReadData("Введите кол.столб ");
int [,] arr2D = Fill2DArray(row, col, 0, 9);
Print2DArray(arr2D);
Console.WriteLine("Упорядоченный массив: ");
Print2DArray(UpDateArr(arr2D));
