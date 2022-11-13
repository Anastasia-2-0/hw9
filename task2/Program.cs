// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
 

Console.WriteLine("Введите число M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());

int sum = 0;
void GapNumberSum (int numberM, int numberN)
{
   
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN);
}

GapNumberSum(m, n);