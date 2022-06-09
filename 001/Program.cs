// Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"


Console.WriteLine("Введите значение m:  ");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение n:  ");
double num2 = double.Parse(Console.ReadLine());
string line = string.Empty;
AllNums( num1, num2);

void AllNums(double num1, double num2)
{
    for(double i = num1; i <= num2; i++)
{
    Console.Write ($"{i}");
}
}

