// Найти сумму цифр числа

int SumOfNumber (int n)
{
    int b = n % 10;
    if (n < 1) return 0;
    else return SumOfNumber (n/10) + b;
}

Console.Write (SumOfNumber (856));

