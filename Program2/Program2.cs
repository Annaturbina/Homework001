// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("a = " +num1);

Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b = " +num2);

if(num1 > num2)
{
    Console.WriteLine($"{num1} максимальное число");
}
else 
{
    Console.WriteLine($"{num2} максимальное число");
}



