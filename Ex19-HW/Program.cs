/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

/* 1 вариант - деление и остаток - работает!!!*/
// int InputNum(string message)
// {
//     Console.Write(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// string Palindrom(int num)
// {
//     if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
//         return "Это число является палиндромом!";
//     else
//         return ("Это число не является палиндромом..");
// }

// int num = InputNum("Введите пятизначное число: ");
// if (num <= 99999 && num > 9999)
//     Console.WriteLine($"{Palindrom(num)}");
// else
//     Console.WriteLine("Это не пятизначное число..");

/* 2 вариант - массив - работает но только для пятизначных, и не говорит, если вдруг не пятизначное число?!
шестизначный палиндром, например, не считает палиндромом..*/
int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int num = InputNum("Введите пятизначное число: ");

int temp = num;
int count = 0;
while (temp != 0)
{
    temp = temp / 10;
    count++;
}

int[] array = new int[count];

for (int i = array.Length - 1; i >= 0; i--)
{
    array[i] = num % 10;
    num /= 10;
}

if (array[0] == array[4] && array[1] == array[3])
    Console.WriteLine("Это число является палиндромом!");
else
    Console.WriteLine("Это число не является палиндромом..");

// Ниже Дмитрий подсказал, но я не поняла этого(
// bool check = true;
// for (int i = 0; i < array.Length / 2; i++)
// {
// check = check & array[i] == array[array.Length - 1 - i];
// }

// Ниже Дмитрий тоже подсказал другой вариант с переворотом, но я не поняла этого(
// int reverseNum = 0;
// int temp = number;
// while(temp > 0)
// {
// reverseNum = reverseNum * 10 + temp % 10;
// temp = temp / 10;
// }
// if(number == reverseNum)
// …

/*3 вариант - не работает!! то же, что и второй, но попыталась сделать, чтобы брал только пятизначные и писал, если оно не пятизначное
*/
// int InputNum(string message)
// {
//     Console.Write(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// int num = InputNum("Введите пятизначное число: ");

// int temp = num;
// int count = 0;
// while (temp != 0)
// {
//     temp = temp / 10;
//     count++;
// }

// int[] array = new int[count];

// for (int i = array.Length - 1; i >= 0; i--)
// {
//     array[i] = num % 10;
//     num /= 10;
// }

// string Palindrom(int[] array)
// {
//     if (array[0] == array[4] && array[1] == array[3])
//         return "Это число является палиндромом!";
//     else
//         return "Это число не является палиндромом..";
// }


// if (num <= 99999 && num > 9999)
//     Console.WriteLine($"{Palindrom(array)}");
// else
//     Console.WriteLine("Это не пятизначное число..");