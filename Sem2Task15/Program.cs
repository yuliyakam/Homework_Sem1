//Программа принимает цифру, обозначающую день нед. и проверяет является ли этот день выход
Console.WriteLine("Введите номер дня недели, где 1 - это Понедельник ");
string? D = Console.ReadLine();
  if (D != null)
  {
      int Day = int.Parse(D);
      string DayOfWeek = "";//Объявляем глобальную переменную
    switch (Day)
    {// Запускаем оператор выбора, к-й проходит все варианты и при сопадении с чис Day
    //Выдает рез-т, если совпад нет то default выводит сооб "Такого дня не существует"
      case 1: DayOfWeek = "Понедельник"; break;
      case 2: DayOfWeek = "Вторник"; break;
      case 3: DayOfWeek = "Среда"; break;
      case 4: DayOfWeek = "Четверг"; break;
      case 5: DayOfWeek = "Пятница"; break;
      case 6: DayOfWeek = "Суббота"; break;
      case 7: DayOfWeek = "Воскресенье"; break;
      
      default: DayOfWeek = "Такого дня не существует"; break;
    }
    if (DayOfWeek == "Такого дня не существует" ) //Для особо одаренных конкретизируем ввод
    { //Для особо одаренных конкретизируем ввод
      Console.WriteLine("Такого дня не существует! Введите число от 1 до 7");
    }
    else
    {//Проверяем если введено число 6 или 7 выводим выходной день
      Console.WriteLine((Day == 6 || Day  == 7) ? DayOfWeek + " - выходной день" :
      DayOfWeek + " - невыходной день");
    }
  }