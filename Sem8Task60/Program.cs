// Создание трехмерной матрицы из неповторяющихся 2х значных чисел. 
// Вывод в консоль элемента с индексом

//Считываем данные 
int ReadData(string line)
{   
    Console.WriteLine(line);    
    int x1= int.Parse(Console.ReadLine() ?? "0");    
    return x1;  
}
// Метод генерации и заполнения трехмерного массива неповторяющимися двузначными числами
int [,,] Fill3DArray(int countRow, int countColumn, int countZ)
{   int elements = 10;
    //Создаем массив  
    int[,,] array3D = new int[countRow,countColumn,countZ];  
         
        for (int i = 0; i < countRow; i++)
        {    
            for (int j = 0; j < countColumn ; j++)
            {
                for (int k = 0; k < countZ; k++)
                {                 
                    array3D[i,j,k] = elements++;                                    
                }            
            }        
        }
    return array3D;                
}   
//Печатаем двумерный массив
void Print3DArray( int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}");
                Console.Write($"({i},{j},{k}) ");
            }
            Console.WriteLine(); 
        }               
    }   
}

int row = ReadData("Введите кол.строк ");
int col = ReadData("Введите кол.столб ");
int zIndex = ReadData("Введите кол.столб по Z оси ");
int [,,] arr3D = Fill3DArray(row, col, zIndex);
Print3DArray(arr3D);