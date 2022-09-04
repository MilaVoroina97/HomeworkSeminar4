// Написать программу сортировки массива от большего к меньшему. Массив задается размерностью 
//N с клавиатуры, далее заполняется случайными целыми числами.

void FillArray (int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SortArray(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int max_position = i;
        for(int j = i+1; j < array.Length; j++)
        {
            if(array[j] > array[max_position]) 
            {
                max_position = j;
            }
        }
        int temp = array[i];
        array[i] = array[max_position];
        array[max_position] = temp;
    }
}
try
{
    Console.WriteLine("Введите число элементов массива: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] result = new int[N];
    FillArray(result);
    PrintArray(result);
    SortArray(result);
    PrintArray(result);
}
catch
{
    Console.WriteLine("Введите, пожалуйста, целые числа для количества элементов массива");
}
