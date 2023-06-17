/* как прописать функцию, чтобы прописать два числа - самый простой вариант, вернуть массив из двух чисел
*/

// int[] InputSomeNums()
// {
//     int[] twoNums = new int[2];
//     Console.Write("Введите первое число: ");
//     twoNums[0]=int.Parse(Console.ReadLine()!);
//     Console.Write("Введите второе число: ");
//     twoNums[1]=int.Parse(Console.ReadLine()!);
//     return twoNums;
// }

// int[] array=InputSomeNums();
// Console.WriteLine($"{array[0]}, {array[1]}");


int[] InputSomeNums()
{
    Console.Write("Введите количество чисел: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
        else
            Console.Write(".");
    }
}

int[] myArray = InputSomeNums();
PrintArray(myArray);
