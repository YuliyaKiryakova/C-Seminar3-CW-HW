/* Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

// int InputNum (string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// string Quart (int quarter)
// {
//     if (quarter ==1) return ("Координаты х и y должны быть больше 0");
//     else if (quarter ==2) return ("Координата х должна быть меньше 0, а координата y - больше 0");
//     else if (quarter ==3) return ("Координаты х и y должны быть меньше 0");
//     else if (quarter ==4) return ("Координата х должна быть больше 0, а координата y - меньше 0");
//     else return ("Такой четверти нет");
// }

// int quarter = InputNum("Введите номер четверти: ");
// string res = Quart(quarter);
// Console.WriteLine(res);


void Coord(string message) 
{ 
 System.Console.WriteLine(message); 
 int a = int.Parse(System.Console.ReadLine()!); 
 if (a > 0 && a < 5) 
 { 
 if (a == 1) 
 System.Console.WriteLine("x > 0, y > 0."); 
 else if (a == 2) 
 System.Console.WriteLine("x < 0, y > 0."); 
 else if (a == 3) 
 System.Console.WriteLine("x < 0, y < 0."); 
 else if (a == 4) 
 System.Console.WriteLine("x > 0, y < 0."); 
 } 
 else 
 System.Console.WriteLine("Такой четверти нет."); 
} 
Coord("Введите номер четверти: ");