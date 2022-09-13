int ReadData(string number)
{   
    Console.WriteLine(number);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}
string ChoeseOperation(string line)
{
    Console.Write(line);
    string operation = Console.ReadLine();
    return operation;
}
/*string typeOfOperation(string choese)
{    
    string operation = "";
switch (choese)
{ case "+" : operation = "Сложение"; break;
  case "-" : operation = "Вычитание"; break;
  case "/" : operation = "Деление"; break;
  case "*" : operation = "Умножение"; break;
  case "^" : operation = "Возведение в степень"; break;    
    default: operation = "К сожалению это действие не доступно"; break; 
    
}
}
double TestOperation(string operat, double num1, double num2)
{
    double res1 = 0; double res2=0; double res4=0;
    double res3=0; double res5 = 0;
if (operat == "Сложение"){  res1 = num1 + num2;}
return res1;
if (operat == "Вычитание") { res2 = num1 - num2;}
return res2;
if (operat == "Деление") { res3 = num1 / num2;}
return res3;
if (operat == "Умножение") { res4 = num1 * num2;}
return res4;
if (operat == "Возведение в степень") { res5 =Math.Pow(num1, num2);}
return res5;
}*/
double Calc(string [] array, double num1, double num2)
{
    double res = 0;
    string array[5]  = {"+","-","/","*","^"}
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]=="+")  res = num1 + num2;
        if (array[i]=="-")  res = num1 - num2;
        if (array[i]=="/")  res = num1 / num2;
        if (array[i]=="*")  res = num1 * num2;
        if (array[i]=="^")  res = Math.Pow(num1, num2);
    }
    return res;
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int number1 = ReadData("Введите 1 число ");
string operation = ChoeseOperation("Введите действие -,+,/,* ,^(возведение в степень) ");
int number2 = ReadData("Введите 2 число ");

PrintResult("Результат = "+Calc(operation, number1, number2));