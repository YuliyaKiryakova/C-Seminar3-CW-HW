/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел 
от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125.
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int num = InputNum("Введите число: ");
for (int i = 1; i <= num; i++)
{
    Console.Write($"{Math.Pow(i, 3)}");
    if (i < num) Console.Write(", ");
    else Console.Write(".");
}

