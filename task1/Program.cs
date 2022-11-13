// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"


Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
ChetNumbers(number);

void ChetNumbers(int number)
{
    if (number < 0)
    {
        Console.Write($"{number} не натуральное число");
    }
    if (number % 2 == 0)
    {
        Console.Write(number);
        Console.Write(",");
    }
    while (number > 1)
    {
    ChetNumbers(number - 1);
    }
}
