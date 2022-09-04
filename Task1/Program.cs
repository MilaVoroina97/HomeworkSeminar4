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


double Stepen(int x,int y)
{
    double power = Math.Pow(x,y);
    Console.WriteLine($"{x}**{y} = {power}");
    return power;
}
Console.WriteLine("Enter first integer number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second integer number");
int b = Convert.ToInt32(Console.ReadLine());
double res = Stepen(a,b);




