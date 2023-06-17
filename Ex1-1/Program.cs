/* как число сделать массивом, то есть, чтобы каждая цифра в числе имела свой индекс
*/

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

int num = int.Parse(Console.ReadLine()!);
int temp = num;

int count = 0;
while (temp != 0)
{
    temp = temp / 10; // temp/=10;
    count++;
}

int[] array = new int[count];

for (int i = array.Length - 1; i >= 0; i--)
{
    array[i] = num % 10;
    num /= 10;
}

PrintArray(array);
Console.Write($"\n{array[2]}");