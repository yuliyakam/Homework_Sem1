//==================================================================
// Программа, которая принимает на вход 3 числа  и выдает max из них
//==================================================================
Console.Write("Введите первое число ");
string? firstNumber = Console.ReadLine();
Console.Write("Введите второе число ");
string? secondNumber = Console.ReadLine();
Console.Write("Введите третье число ");
string? thirdNumber = Console.ReadLine();
 if (firstNumber != null&&secondNumber != null&&thirdNumber != null)
 {
    int first = int.Parse(firstNumber);
    int second = int.Parse(secondNumber);
    int third = int.Parse(thirdNumber);
    if (first > second)      
    {
      if (first > third) 
      {
         Console.Write("Максимальное число ");
         Console.WriteLine(first);
      }
      else
      {
         Console.Write("Максимальное число ");
         Console.WriteLine(third);
      }
    }
    else
    {
      if (second > third)
      {
         Console.Write("Максимальное число ");
         Console.WriteLine(second);
      }
      else
      {
         Console.Write("Максимальное число ");
         Console.WriteLine(third);
      }
    }
 }