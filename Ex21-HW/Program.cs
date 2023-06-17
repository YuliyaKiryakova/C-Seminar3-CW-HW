/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int x1 = InputNum("Введите x для первой точки: ");
int y1 = InputNum("Введите y для первой точки: ");
int z1 = InputNum("Введите z для первой точки: ");
int x2 = InputNum("Введите x для второй точки: ");
int y2 = InputNum("Введите y для второй точки: ");
int z2 = InputNum("Введите z для второй точки: ");

double Cube(int x1, int y1, int z1, int x2, int y2, int z3)
{
    double res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    return res;
}

double distance = Cube(x1, y1, z1, x2, y2, z2);
double result = Math.Round(distance, 2);
Console.WriteLine($"Расстояние между точками {result}");

/* Без функций код для начала мне*/
// Console.Write("Введите x1: ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите y1: ");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите z1: ");
// int z1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите x2: ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите y2: ");
// int y2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите z2: ");
// int z2 = int.Parse(Console.ReadLine()!);

// double res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
// double result = Math.Round(res, 2);
// Console.WriteLine(result);
