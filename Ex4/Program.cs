// Написать программу вычисления функции Аккермана
int Accermen(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Accermen(n - 1, 1);
    else
      return Accermen(n - 1, Accermen(n, m - 1));
}

Console.WriteLine (Accermen (3, 5));