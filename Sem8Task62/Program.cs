// Программа спирально заполняет двумерный массив

//Считываем данные 
int ReadData(string line)
{   
    Console.WriteLine(line);    
    int x1= int.Parse(Console.ReadLine() ?? "0");    
    return x1;  
}
// Метод генерации и заполнения двумерного массива по спирали
int [,] Fill2DArray(int countRow, int countColumn)
{   int rowStart = 0;
    int rowEnd = 0;  
    int columnStart = 0;
    int columnEnd = 0;
    // Первый элемент определяем на позицию[0,0]
    int element = 1;
    int i = 0;
    int j = 0;
    // Создаем массив
    int[,] array2D = new int[countRow,countColumn];       
    while (element<=countRow*countColumn)
    {
        array2D[i,j] = element;
        // Проверяем положение элемента, если вначале матрицы, то движемся вправо по столбцам      
            if ((i == rowStart)&&(j<countRow-columnEnd-1)) j++;
        // Если достигли правой границы - движемся вниз по строкам
            else if((j==countRow-columnEnd-1)&&(i<countColumn-rowEnd-1)) i++;
        //  Если достигли нижней границы - движемся влево по столбцам
            else if((i==countColumn-rowEnd-1)&&(j>columnStart)) j--;
        // Если достигли левой границы - движемся вверх по строкам
            else --i;
            if ((i==rowStart+1)&&(j==columnStart)&&(columnStart!=countRow-columnEnd-1))
            {
                rowStart++;
                rowEnd++;
                columnStart++;
                columnEnd++;
            }              
        element++;            
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
            if (array[i,j]<10)
            Console.Write($"0{array[i,j]} ");
            else Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();        
    }   
}

int row = ReadData("Введите кол.строк ");
int col = ReadData("Введите кол.столб ");
int [,] firstMatrix = Fill2DArray(row, col);
Print2DArray(firstMatrix);