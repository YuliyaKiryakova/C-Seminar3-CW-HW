/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int num = InputNum("Введите число: ");
for (int i = 1; i <= num; i++)
{
    Console.Write($"{Math.Pow(i, 2)}");
    if (i < num)
        Console.Write(", ");
    else
        Console.Write(".");
}
