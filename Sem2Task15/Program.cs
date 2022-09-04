//Программа принимает цифру, обозначающую день нед. и проверяет является ли этот день выход
Console.WriteLine("Введите номер дня недели, где 1 - это Понедельник ");
string? D = Console.ReadLine();
if (D != null)
{
    int Day = int.Parse(D);
    string DayOfWeek = "";
   switch (Day)
   {
     case 1: DayOfWeek = "Понедельник"; break;
     case 2: DayOfWeek = "Вторник"; break;
     case 3: DayOfWeek = "Среда"; break;
     case 4: DayOfWeek = "Четверг"; break;
     case 5: DayOfWeek = "Пятница"; break;
     case 6: DayOfWeek = "Суббота"; break;
     case 7: DayOfWeek = "Воскресенье"; break;
    
    default: DayOfWeek = "Такого дня не существует"; break;
   }
   if (DayOfWeek == "Такого дня не существует" )
   {
     Console.WriteLine("Такого дня не существует! Введите число от 1 до 7");
   }
   else
   {
    Console.WriteLine((Day == 6 || Day  == 7) ? DayOfWeek + " - выходной день" :
    DayOfWeek + " - невыходной день");
   }

}