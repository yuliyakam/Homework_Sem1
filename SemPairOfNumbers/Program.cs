// Посчитать количество пар чисел в массиве

//Считываем данные 
int ReadData(string line)
{   
    Console.WriteLine(line);   
    //Считываем число и преобразуем из строки в int
    int x1= int.Parse(Console.ReadLine() ?? "0"); 
    //Возвращаем значение
    return x1;  
}
//Универсальный метода генерации и заполнения массива
int [] FillArray(int num, int downBorder, int topBorder)
{   //Генератор случайных чисел
    Random numSintezator = new Random();
    //Создаем массив
    int[] array = new int[num];
    //Тест границ
    if (downBorder < topBorder)
    { //Заполнение массива
           for (int i = 0; i < array.Length; i++)
           {
                array[i] = numSintezator.Next(downBorder, topBorder + 1);
           }
    }   
return array;
}
//Печатаем одномерный массив
void Print1DArray( int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i]+",");
    }
    Console.WriteLine(array[array.Length-1]);
}
void CountPairOfNumbers(int[] array)
{       
    for (int i = 0; i < array.Length; i++)
    { int count = 0;
        for (int j = i + 1; j < array.Length; j++)
        {              
           if (array[i] == array[j])
           {
                count++;              
           }  
           Console.Write(" Кол. пар " + array[i] + "="  + count);                                
        }                
    }        
}
//Выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrayLen = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите нижнюю границу массивва: ");
int topBorder = ReadData("Введите верхнюю границу массивва: ");
int[] Array = FillArray(arrayLen, downBorder, topBorder);
Print1DArray(Array);
CountPairOfNumbers(Array);
