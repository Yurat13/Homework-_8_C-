// Написать программу возведения числа А в целую стень B
int Exponention (int a, int b)
{
    if (b == 1) 
        return a;
    if (b != 1) 
        return a * Exponention (a, b - 1);
}

Console.WriteLine(Exponention(2, 3));
