// /*
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
// */

// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
// return new int[size];
// }

// void FillArray(int[] array, int min, int max)
// {
// Random rnd = new Random(); // создание экземпляра класса Random
// for (int i = 0; i < array.Length; i++)
// array[i] = rnd.Next(min, max + 1); // [min, max) полуинтервал
// // array[i] = new Random().Next(min, max + 1)
// }
// string PrintArray(int[] array)
// {
// string res = String.Empty;
// for (int i = 0; i < array.Length; i++)
// res += array[i] + " ";
// return res;
// }

// int SumPositiveNums(int[] array)
// {
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// if (array[i] > 0)
// sum += array[i];
// return sum;
// }
// int SumNegativeNums(int[] array)
// {
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// if (array[i] < 0)
// sum += array[i];
// return sum;
// }

// int size = InputNum("Введите размер массива: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");

// int[] myArray = CreateArray(size);
// FillArray(myArray, minValue, maxValue);
// string txt = PrintArray(myArray);
// Console.WriteLine(txt);

// int pos = SumPositiveNums(myArray);
// int neg = SumNegativeNums(myArray);

// Console.WriteLine($"Сумма положительных элементов равна {pos}");
// Console.WriteLine($"Сумма отрицательных элементов равна {neg}");

// ********************************************************
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
//     return new int[size];
// }

// void FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random(); // создание экземпляра класса Random
//     for (int i = 0; i < array.Length; i++)
//         array[i] = rnd.Next(min, max + 1); // [min, max) полуинтервал
//                                            // array[i] = new Random().Next(min, max + 1)
// }
// string PrintArray(int[] array)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//         res += array[i] + " ";
//     return res;
// }

// void InvertArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = array[i] * -1;

// }
// int size = InputNum("Введите размер массива: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");

// int[] myArray = CreateArray(size);
// FillArray(myArray, minValue, maxValue);
// string txt = PrintArray(myArray);
// Console.WriteLine(txt);
// InvertArray(myArray);
// txt = PrintArray(myArray);
// Console.WriteLine(txt);



// ********************************************************
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
//     return new int[size];
// }

// void FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random(); // создание экземпляра класса Random
//     for (int i = 0; i < array.Length; i++)
//         array[i] = rnd.Next(min, max + 1); // [min, max) полуинтервал
//                                            // array[i] = new Random().Next(min, max + 1)
// }
// // string PrintArray(int[] array)
// // {
// //     string res = String.Empty;
// //     for (int i = 0; i < array.Length; i++)
// //         res += array[i] + " ";
// //     return res;
// // }

// void PrintArray(int[] array) // Альтернативная печать массива через foreach
// {
// foreach (int item in array)
// {
// Console.Write($"{item} ");
// }
// Console.WriteLine();
// }

// bool SearchArray(int[] array, int search)
// {
//     bool result = false;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] == search) result = true;
//     return result;
// }
// int size = InputNum("Введите размер массива: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");
// int searchValue = InputNum("Введите значение поиска: ");


// int[] myArray = CreateArray(size);
// FillArray(myArray, minValue, maxValue);
// // string txt = PrintArray(myArray);
// // Console.WriteLine(txt);
// PrintArray(myArray);
// bool result = SearchArray(myArray, searchValue);
// Console.WriteLine($"Наличие элемента поиска в массиве: {result}");

// *************************************************************
// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
//     return new int[size];
// }

// void FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random(); // создание экземпляра класса Random
//     for (int i = 0; i < array.Length; i++)
//         array[i] = rnd.Next(min, max + 1); // [min, max) полуинтервал
//                                            // array[i] = new Random().Next(min, max + 1)
// }


// void PrintArray(int[] array) 
// {
// foreach (int item in array)
// {
// Console.Write($"{item} ");
// }
// Console.WriteLine();
// }

//  int BetweenBorders(int[] array, int min, int max)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] <= max && array[i] >= min) result = result + 1;
//     return result;
// }



// int size = InputNum("Введите размер массива: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");
// int minBorder = InputNum("Введите минимальное значение границы поиска: ");
// int maxBorder = InputNum("Введите максимальное значение границы поиска: ");
// int[] myArray = CreateArray(size);
// FillArray(myArray, minValue, maxValue);
// PrintArray (myArray);

// Console.WriteLine($"На отрезке {minBorder} и {maxBorder} лежит {BetweenBorders(myArray, minBorder, maxBorder)} элементов");

// ************************************************
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random(); // создание экземпляра класса Random
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(min, max + 1); // [min, max) полуинтервал
                                           // array[i] = new Random().Next(min, max + 1)
}


void PrintArray(int[] array) 
{
foreach (int item in array)
{
Console.Write($"{item} ");
}
Console.WriteLine();
}

// void MultiplyArrayElements (int[] array)
// {
//     int i = 0;
//     while (i < (array.Length - 1 - i))
//     {
//         Console.Write($"{array[i] * array[array.Length - 1 - i]} ");
//         i++; 
//     }
// }

int[] MultiArray (int[] array)
{
    int[] resultArray = new int[array.Length / 2]; 
    int i = 0;

    while (i < (array.Length - 1 - i))
    {
       resultArray[i] = array[i] * array[array.Length - 1 - i];
        i++; 
    }
    return resultArray;
}



int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[] myArray = CreateArray(size);
FillArray(myArray, minValue, maxValue);
PrintArray (myArray);
// MultiplyArrayElements(myArray);
PrintArray (MultiArray(myArray));  

