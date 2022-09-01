//==================================================================
// Программа, которая принимает на вход числo N, а на выходе показывает
// все четные числа от 1 до N
//==================================================================
Console.Write("Введите число больше единицы ");
string? Number = Console.ReadLine();
if ( Number != null )
{
int NumberN = int.Parse(Number);
int count = 1;
while (count < NumberN)
{  
        if (count % 2 == 0) 
        {
            Console.Write(count);
            Console.Write(","); 
        }  
    count++;
}
}