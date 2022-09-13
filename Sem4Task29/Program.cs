//Программа задает массив и выводит их на экран
//Принимаем значения от пользователя
int ReadData(string line)
{   
    Console.WriteLine(line);     
    int x1= int.Parse(Console.ReadLine() ?? "0");     
    return x1;  
}
//Генирируем массив с рандомными значениями
int [] GenArray(int arrayLength, int start, int stop)
{   //Объявляем о создании рандомного значения
    Random ren = new Random();
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {//Указываем диапазон допустимых значений,stop+1-чтобы вошел элемент 
        array[i] = ren.Next(start, stop+1);
    }
return array;
}
//Выводим массив
void printArray( int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i]+",");
    }
    Console.WriteLine(array[array.Length-1]);
}
//Считываем параметры массива
int count = ReadData("Введите количество элементов ");
int start = ReadData("Введите начало диапазона ");
int stop = ReadData("Введите конец диапазона ");
int []array = GenArray(count, start, stop);
printArray(array);