// 50* Заполнить двумерный массив числами Фибоначчи, найти запрашиваемое число и вывести
//это число в массиве другим цветом

//Считываем данные 
int ReadData(string line)
{   
    Console.WriteLine(line);   
    //Считываем число и преобразуем из строки в int
    int x1= int.Parse(Console.ReadLine() ?? "0"); 
    //Возвращаем значение
    return x1;  
}
// Генерация одномерного массива, заполненного числами Фибоначчи
int[] Fibonacci(int numFib)
{
    int[] fibonacciArr = new int[numFib];
    fibonacciArr[1] = 1;
        for (int i = 2; i < numFib; i++)
        {
            fibonacciArr[i] = fibonacciArr[i-2] + fibonacciArr[i - 1];
        }
    return fibonacciArr;
}
// Генерации и заполнения двумерного массива числами Фибоначчи
int [,] Fill2DArrayFibonacciNumber(int countRow, int countColumn)
{    
    // Создаем массив
    int[,] array2D = new int[countRow,countColumn];  
    int[] array = Fibonacci(array2D.GetLength(0)*array2D.GetLength(1));   
    int n = 3; 
    // Заполнение массива                 
        for (int i = 0; i < countRow; i++)
        {    
            if (i==0)  
                {
                    for (int j = 0; j < countColumn ; j++)
                    {   
                        array2D[i,j] = array[j];         
                    }
                }
            else {
            for (int k = 0; k < countColumn; k++)
            {
                array2D[i,k] = array[i+k+n+1];
            }
            n=n+4;
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
// Печатаем двумерный массив c Выделенным искомым элементом
void PrintColorElement2DArray( int[,] array, int row, int column)
{   
    if ((row < array.GetLength(0))&&(column < array.GetLength(1)))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {          
                Console.Write($"{array[i,j]} ");              
                    if ((i==row)&&(j==column)) 
                    {       
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(array[i,j]);
                        Console.ResetColor();     
                    }      
            }
            Console.WriteLine();        
        } 
    } 
    else
    {
        Console.WriteLine("Элемента с заданными параметрами в данном массиве нет");
    } 
}

int row = ReadData("Введите кол.строк ");
int col = ReadData("Введите кол.столб ");
int [,] arr2D = Fill2DArrayFibonacciNumber(row, col);
Print2DArray(arr2D);
int x = ReadData("Введите номер строки искомого элемента");
int y = ReadData("Введите номер столбца искомого элемента");
PrintColorElement2DArray(arr2D, x, y); 

