// Произведение двух матриц

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
// Произведение двух матриц
int[,] ProductOfMatrixs (int[,] arr1, int[,] arr2)
{    
    int[,] productMatrix = new int[arr1.GetLength(0),arr1.GetLength(1)];
     for (int i = 0; i < arr1.GetLength(0); i++)
      {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
           for (int k = 0; k < arr2.GetLength(0); k++)
           {
                productMatrix[i,j] += arr1[i,k]*arr2[k,j];
           }                     
        }     
      } 
      return productMatrix;       
    }   

int row = ReadData("Введите кол.строк ");
int col = ReadData("Введите кол.столб ");
int [,] firstMatrix = Fill2DArray(row, col, 0, 9);
Print2DArray(firstMatrix);
Console.WriteLine();
int [,] secondMatrix = Fill2DArray(row, col, 0, 9);
Print2DArray(secondMatrix);
Console.WriteLine("Произведение двух матриц: ");
Print2DArray(ProductOfMatrixs(firstMatrix, secondMatrix));

