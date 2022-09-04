//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

// First way:


// void Stepen(int x, int y)

// {  
//     Console.WriteLine($"{x}^{y} = {Math.Pow(x, y)}");
// }

// Console.WriteLine("Enter first integer number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second integer number");
// int b = Convert.ToInt32(Console.ReadLine());
// Stepen(a,b);

// Second Way:

int Stepen (int x,int y)
{
    int power = 1;
    for(int i = 0; i < y; i++)
    {
        power = power * x;
    }
    return power;
}
 Console.WriteLine("Enter first integer number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second integer number");
int b = Convert.ToInt32(Console.ReadLine());
int res = Stepen(a,b);
Console.WriteLine(res);





