// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12
int NumberSum(int a)
{
    string b = Convert.ToString(a);
    int length = b.Length;
    int sum = 0;
    int res = 0;
    for (int i = 0; i < length; i++)
    {
        res = a - (a % 10);
        sum = sum + (a - res);
        a = (a / 10);
    }
    return sum;

}
try
{
    Console.WriteLine("Введите любое целое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int sum = NumberSum(a);
    Console.WriteLine(sum);
}
catch
{
    Console.WriteLine("Please enter integer number");
}
