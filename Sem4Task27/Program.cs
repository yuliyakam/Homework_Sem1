//Программа считает сумму цифр в числе
int ReadData(string number)
{   
    Console.WriteLine(number);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}
//1Метод
int sumNumbers(int numberN)
{   int sum = 0;
    while ( numberN >= 1 )  
    {   sum = sum + (numberN%10);
        numberN = numberN/10;
    }
    return sum;
}
//2Метод подсчета суммы через преобразование числа в массив
int arrayMetod(int num)
{ 
    int length = 0;    
    int sum = 0;
    int num1 = num;  
     while (num>0)
    {
        length+=1; 
        num=num/10;              
    }
    int arrayLen = length;  
    int [] array = new int [arrayLen];
    for (int i = 0; i < arrayLen; i++)
    {        
        array[i] = num1%10;
        sum = sum + array[i];
        num1 = num1/10;
    }
    return sum;
}
//Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int number = ReadData("Введите число ");

DateTime d1 = DateTime.Now;
PrintResult("1Метод Сумма цифр в числе = " + sumNumbers(number));
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
PrintResult("2 Сумма цифр в числе = " + arrayMetod(number));
Console.WriteLine(DateTime.Now - d2);