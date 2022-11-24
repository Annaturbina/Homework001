// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
    
for (int num = 1; num <= N; num++)
    if (num % 2 == 0)
    {
        Console.Write($"{num} ");
    }
    