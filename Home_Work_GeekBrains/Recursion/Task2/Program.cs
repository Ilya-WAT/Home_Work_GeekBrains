Console.Write("Введите значение параметра m: ");
int inputm = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение параметра n: ");
int inputn = Convert.ToInt32(Console.ReadLine());
int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m-1,1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m-1, Ackermann(m, n - 1));
    }
    return 0;
}
Console.WriteLine(Ackermann(inputm, inputn));