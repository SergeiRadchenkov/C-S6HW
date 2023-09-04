/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите число: ");
        arr[i] = int.Parse(Console.ReadLine()!);
    }
}

void PrintArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length -1; i++)
        Console.Write(arr[i] + ", ");
    Console.Write(arr[arr.Length -1]);
     for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    Console.WriteLine();
    Console.Write($"{count} - чисел больше нуля");
}

int size = InputNum("Введите количество чисел: ");
int[] array = CreateArray(size);
FillArray(array);
PrintArray(array);


/* int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
} 

void Numbers(int num)
{
    Console.Write(num);
    Console.WriteLine();
    string b = $"{num}";
    while (num != 0)
    {
        Console.Write("Введите число: ");
        string a = Console.ReadLine()!;
        b = b + $", {a}";
        Console.Write(b);
        Console.WriteLine();
    }
}

int number = InputNum("Введите число: ");
Numbers(number); */
