// Напишите программу вычисления функции 
//Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n. 
//m = 2, n = 3 -> A(m,n) = 29


int Ackerman( int n, int m)
{
  if (n == 0)
    return m + 1;
  
  else
    if ((n != 0) && (m == 0))
      return Ackerman(n - 1, 1);
    else
      return Ackerman(n - 1, Ackerman(n, m - 1));
}


int m = 2;
int n = 3;
Ackerman(n,m);