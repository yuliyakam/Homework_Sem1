//Программа из строки выводит рандомное имя
string text = "Александр,Игорь,Сергей,Иван,Макар,Олег";
string [] names = text.Split(',');
int ren = new Random().Next(0, names.Length+1);
Console.WriteLine("Исполнителем назначен: " + names[new Random().Next(0, names.Length)]);