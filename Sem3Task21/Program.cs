/*Напишите программу, которая принимает на вход
координаты трех точек и находит расстояние между
ними в 3D пространстве.*/

//считываем данные
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
   
    //Считываем число
    int Coordinate= int.Parse(Console.ReadLine() ?? "0");    

    //Возвращаем значение
    return Coordinate;
  
}
//Высчитываем значение
double Colculate(int x1, int x2, int y1, int y2, int z1, int z2)
{     
  double res = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));
  return res;
}
//Выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x1 = ReadData("Введите координату х1: ");
int x2 = ReadData("Введите координату x2: ");
int y1 = ReadData("Введите координату у1: ");
int y2 = ReadData("Введите координату у2: ");
int z1 = ReadData("Введите координату z1: ");
int z2 = ReadData("Введите координату z2: ");

PrintResult("Расстояние = " + Math.Round(Colculate(x1, x2, y1, y2, z1, z2),2));

