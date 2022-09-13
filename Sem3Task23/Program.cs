/*Напишите программу, которая принимает на вход
число (N) и выдаёт таблицу кубов чисел от 1 до
N.*/
//считываем число из консоли
void ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
   
    //Считываем число
    int x1= int.Parse(Console.ReadLine() ?? "0");    

    //Возвращаем значение
    return x1;
  
}
//Собираем строку от 1 до N, где pow - показатель степени
string LineNumbers(int number, int pow) 
{
    int i = 1;
    string outline = "";

    while(i<=number)
    {
        outline = outline+Math.Pow(i,pow)+"\t";
        i++;
    }
  
    return outline;
}
//Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N: ");
PrintResult(LineNumbers(num,1));
PrintResult(LineNumbers(num,3));