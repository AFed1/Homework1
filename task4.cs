// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите первое число (за исключением отрицательных)");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

for (int i = 1; i <= num1int; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}