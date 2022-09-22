void ShowNumbers (int m, int n)
{
    if (n < m) return;
    ShowNumbers (m, n - 1);
    Console.Write ($"{n} ");
}

ShowNumbers (5, 10);