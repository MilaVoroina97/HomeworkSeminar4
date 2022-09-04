// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]


int[] FillArray(string x)
{
    int[] array = new int[8];
    int j = 0;
    for (int i = 0; i < x.Length; i++)
    {
        string y = "";
        y = y + x[i];
        array[j] = Convert.ToInt32(y);
        j++;
    }
    return array;
}
    void PrintArray(int[] massiv)
    {
        int size = massiv.Length;
        Console.Write("[");
        for(int i = 0; i < size; i++)
        {
            Console.Write(massiv[i]);
            Console.Write(",");
        }
        
         Console.Write("]");
    }
try
{
    Console.WriteLine("Введите 8 целых чисел");
    string N = Console.ReadLine();
    int[] result = FillArray(N);
    PrintArray(result);
}
catch
{
    Console.WriteLine("Please enter integer numbers without spaces and dots");
}

    


