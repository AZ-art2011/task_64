// Задача 64. Задайте значение N. Напишите программу, которая выведет
// натуральные числа от N до 1 с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Укажите верхнюю границу > 1:");
int num = Convert.ToInt32(Console.ReadLine());

void Count (int num)
{
    if (num < 0) Console.Write($"{num} не натуральное число");
    if (num == 0) return;
    Console.Write($"{num} ");
    Count (num - 1);
}

Count(num);
