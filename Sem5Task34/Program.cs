// Программма заполняет массив случайными трехзначными числами и подсчитывает кол-во четных

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
//Находим чет.числа и считаем их кол-во
int EvenCount(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (TestEven(item))
        {
            count++;
        }
    }
    return count;
}
//Метод проверки числа на четность
bool TestEven(int number)
{
    return number%2 == 0;
}
//Сортировка пузырьком
void BubleSortArray( int[] array)
{
    for (int j = 0; j < array.Length - 1; j++)
    {//Т.к.на первой итерации бОльш.эл становится с краю в длине массива его позицию можно не 
    //учитывать, поэтому array.Length-1-j
        for (int i = 0; i < array.Length-1-j; i++)
        {
            if(array[i] > array[i + 1])
            { 
            int num = array[i + 1];
            array[i + 1] = array[i];
            array[i] = num;
            }
        }   
         Console.Write(array[j]+",");
    }   
    Console.WriteLine(array[array.Length-1]);
}

// Сортировка массива вставками
void InsertSortArray(int[] array)
{ 
    int index = 0;
    int currentNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {  
    index = i; 
    currentNumber = array[i];
   
    while (index > 0 && currentNumber < array[index-1])
    {
        array[index] = array [index - 1];
        index --;
    }
    array[index] = currentNumber;
    }
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i]+",");   
    }
        Console.WriteLine(array[array.Length-1]);
}

//Выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrayLen = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите трехзначное число - нижнюю границу массива: ");
int topBorder = ReadData("Введите трехзначное число - верхнюю границу массива: ");
int[] Array = FillArray(arrayLen, downBorder, topBorder);
Print1DArray(Array);
PrintResult("Количество четных элементов = " + EvenCount(Array));
Console.WriteLine("Массив, отсортированный методом пузырька:");
BubleSortArray(Array);
Console.WriteLine("Массив, отсортированный методом вставок:");
InsertSortArray(Array);

