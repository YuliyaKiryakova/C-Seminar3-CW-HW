/* Прога на вход принимает координаты двух точек и находит расстояние между ними в 2D пространстве
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
// 1 вариант
// Console.Write("Введите x1: ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите y1: ");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите x2: ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите y2: ");
// int y2 = int.Parse(Console.ReadLine()!);

// double res = Math.Sqrt(Math.Pow(x1- x2, 2) + Math.Pow(y1 - y2, 2));
// double result = Math.Round(res, 2);
// Console.WriteLine(result);

// 2 вариант
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int xA = InputNum("Введите x для A: ");
int yA = InputNum("Введите y для A: ");
int xB = InputNum("Введите x для B: ");
int yB = InputNum("Введите y для B: ");

double Root(int xA, int yA, int xB, int yB)
{
    double res = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
    return res;
}

double distance = Root(xA, yA, xB, yB);
Console.WriteLine(Math.Round(distance, 2));

// 3 вариант
// System.Console.WriteLine("Введите кординату xa: ");
// double xa = double.Parse(Console.ReadLine()!);

// System.Console.WriteLine("Введите кординату xb: ");
// double xb = double.Parse(Console.ReadLine()!);

// System.Console.WriteLine("Введите кординату ya: ");
// double ya = double.Parse(Console.ReadLine()!);

// System.Console.WriteLine("Введите кординату yb: ");
// double yb = double.Parse(Console.ReadLine()!);

// double dist = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
// System.Console.WriteLine(dist);
