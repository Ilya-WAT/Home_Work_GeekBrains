Console.Write("Введите длину массива: ");
int inputsize = Convert.ToInt32(Console.ReadLine());
int[] MakeArray(int size)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
    Console.Write($"Введите {i+1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ReverseArray(int[] arr, int counter)
{
    if (counter >= 0)
    {
    Console.Write($"{arr[counter]} ");
    ReverseArray(arr, counter - 1);
    //Console.Write($"{arr[counter]} ");
    }
    else if (counter < 0)
    {
    return;
    }
}
ReverseArray(MakeArray(inputsize), inputsize - 1);