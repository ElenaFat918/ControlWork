// Написать программу, которая из массива строк формирует массив из строк, длина которых меньше либо равна
// 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исклбчительно массивами.

// Примеры
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "-2", "Kazan"] -> []

Console.Clear();
Console.WriteLine($"Программа создающая из массива строк массив из строк, длина которых меньше либо равна 3 символа");


void inputArray(string[] array)
{
    int Lenght = array.Length;

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
        string element = new string(Console.ReadLine()!);
        array[i] = element;
    }
}
void printArray(string[] array)
{
    Console.WriteLine("Введён массив:");
    Console.WriteLine();

    Console.Write("[");

    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }

    Console.Write("]");
    Console.WriteLine();
}

void PrintArrayThreeSimbols(syring[] array)
{
    int i = 0;
    while (temporary <= array.GetLength(0) * array.GetLength(1))
// //     while (temporary <= array.GetLength(0) * array.GetLength(1))
//     {
//         array[i, j] = temporary;
//         temporary++;
//         if (i <= j + 1 && i + j < array.GetLength(1) - 1)
//             j++;
//         else if (i < j && i + j >= array.GetLength(0) - 1)
//             i++;
//         else if (i >= j && i + j > array.GetLength(1) - 1)
//             j--;
//         else
//             i--;
//     }
}

string[] array = new string[8];
inputArray(array);
Console.WriteLine();
printArray(array);


// void SpiralArray(int[,] array)
// {
//     int temporary = 1;
//     int i = 0;
//     int j = 0;

//     while (temporary <= array.GetLength(0) * array.GetLength(1))
//     {
//         array[i, j] = temporary;
//         temporary++;
//         if (i <= j + 1 && i + j < array.GetLength(1) - 1)
//             j++;
//         else if (i < j && i + j >= array.GetLength(0) - 1)
//             i++;
//         else if (i >= j && i + j > array.GetLength(1) - 1)
//             j--;
//         else
//             i--;
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//              if (array[i,j] / 10 <= 0)
//              Console.Write($" {array[i,j]} ");

//              else 
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }