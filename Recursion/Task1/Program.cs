Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
void get_numbers_between(int first,int second)
{
    for (int i = first;i<=second;i++)
    {
        Console.WriteLine(i);
    }
}
get_numbers_between(M,N);

