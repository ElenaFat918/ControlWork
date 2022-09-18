// Написать программу, которая из массива строк формирует массив из строк, длина которых меньше либо равна 
// 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 
 
// Примеры 
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"] 
// ["1234", "1567", "-2", "computer science"] -> ["-2"] 
// ["Russia", "Denmark", "-2", "Kazan"] -> [] 
 
Console.Clear(); 
Console.WriteLine("Программа, создающая из массива строк массив из строк, длина которых меньше либо равна заданному количеству символов"); 
Console.WriteLine("Введите количество элементов в массиве: "); 
int size = int.Parse(Console.ReadLine()!); 

void InputArray(string[] array) 
{ 
    int Length = array.Length; 
 
    for (int i = 0; i < array.Length; i++) 
    { 
        Console.WriteLine($"Введите {i + 1}-й элемент массива: "); 
        string element = new string(Console.ReadLine()!); 
        array[i] = element; 
    } 
} 
void PrintArray(string[] array) 
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

String[] CreateArraySymbols(string[] array)  
{  
    Console.WriteLine("Введите максимальное количество символов в элементе массива: ");  
    int symbol = int.Parse(Console.ReadLine()!);  
    int count = 0;  
    for (var i = 0; i < array.Length; i++)  
    {  
        if (array[i].Length <= symbol)
        count++;
    }  
    string[] result = new string[count]; 
    count = 0;
    for (var i = 0; i < array.Length; i++)      
  {  
        if (array[i].Length <= symbol)
        {
            result[count] = array[i];
            count++;
        }
    }  
    return result; 
}     

string[] array = new string[size]; 
InputArray(array); 
Console.WriteLine(); 

PrintArray(array); 
Console.WriteLine(); 

PrintArray(CreateArraySymbols(array));
Console.WriteLine();