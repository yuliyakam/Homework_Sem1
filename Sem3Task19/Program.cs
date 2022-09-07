/*Программа, которая принимает на вход пятизначное число и проверяет, является ли оно 
палиндромом (зеркальное отражение например 12321)*/

//получаем число из консоли
int ReadData(string line)
 {
    Console.WriteLine(line);
//считываем число и преобразуем из строки в чис
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
 }
 //Проверка на палиндром
 bool TestPalindrom(int number)
 {//деление на 10000 дает 5 циф, %10 дает 1 циф, /1000%10 дает 4циф, /10%10 дает 2 циф
    if ((number/10000 == number%10)&&(number/1000%10) == (number/10%10))
    {
        return true;        
    }
    else
    {
        return false;
    }
 }
//Выводим результат
 void PrintResult(string line)
 {
    Console.WriteLine(line);
 }
 int numberN = ReadData("Введите пятизначное число ");
 PrintResult(TestPalindrom(numberN) == true ? "Да":"Нет"); 