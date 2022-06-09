// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int m = -4;
int n = 9;
GetSum(m,n);

void GetSum(int m, int n)
{
    int sum = 0;
    for(int i = m; i <= n; i++)
    {
         sum = sum + i;
    }
    Console.Write ($"{sum}");
}