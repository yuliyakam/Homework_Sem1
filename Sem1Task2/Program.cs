//=================================================================
// Напишите программу, которая на вход принимает два числа, и выдает 
// какое число большее, а какое меньшее
//=================================================================
Console.Write("Введите первое число ");
string? firstNumber = Console.ReadLine();//Не пустая строка считывается из консоли
Console.Write("Введите второе число ");
string? secondNumber = Console.ReadLine();
    if (firstNumber != null&&secondNumber != null)// Проверяем, что значения не нулевые, для фунции
    // Parse (преобразования строки в число)
    {
    int first = int.Parse(firstNumber);
    int second = int.Parse(secondNumber);
        if ( first > second )
        {
            Console.Write("Большее число: ");
            Console.WriteLine(first);
            Console.Write("Меньшее число: ");
            Console.WriteLine(second);
        }   
        else
        {
            Console.Write("Большее число: ");
            Console.WriteLine(second);
            Console.Write("Меньшее число: ");
            Console.WriteLine(first);
        }
}

