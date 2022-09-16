// Массив заполнить случайными числами, и посчитать сумму элементов на нечет.позициях

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
// Считаем сумму элементов на нечет.позициях
int EvenSumPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {        
        sum += array[i];        
    }
    return sum;
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
PrintResult("Сумма элементов на нечетных позициях = " + EvenSumPosition(Array));
