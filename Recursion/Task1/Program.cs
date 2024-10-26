Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
void get_numbers_between(int first,int second)
{
    if (first > second)
    {
      Console.Write($"{first} ");
      if (first < second)
      {
      return;
      }
      get_numbers_between(first - 1, second);
    }
    else if (first < second)
    {
      Console.Write($"{first} ");
      if (first > second)
      {
      return;
      }
      get_numbers_between(first + 1, second);
    }
    else
    {
        Console.WriteLine(first);
    }
}
Console.Write($"Числа в диапазоне от {M} до {N}: ");
get_numbers_between(M, N);