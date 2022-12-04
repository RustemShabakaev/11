// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int Recalculation(int[] array)
{
    int caunt = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            caunt++;
        }

    }
    return caunt;
}
PrintArray(arr);
int result = Recalculation(arr);
Console.WriteLine($"Результат: {result}");
