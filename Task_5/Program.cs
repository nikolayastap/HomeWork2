//         // Программа, подсчитывает кол-во четных элементов в 
//         // массиве целых положительных трехзначных чисел и
//         // выводит результат на экран. Должна иметь метод 
//         // CountEvenElements, который принимает массив целых
//         // положительных трехзначных чисел и возвращает количество
//         // четных элементов в массиве! Должна иметь метод
//         // PrintArray, который выводит элементы массива на экран.
//         // При выводе элементы массива должны быть разделены
//         // символом табуляции "\t". Если аргументы командной
//         // строки не переданы, программа использует массив по
//         // умолчанию, который содержит следующие значения:
//         // {100, 102, 105, 166, 283, 764, 300, 499, 133}.

// using System;

// public class Answer
// {
//     public static int CountEvenElements(int[] array)
//     {
//         int evenCount = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i]%2 == 0) evenCount++;
//         }
//         return evenCount;
//         // int count = 0;
//         // foreach (int number in array)
//         // {
//         //     if (number % 2 == 0)
//         //     {
//         //         count++;
//         //     }
//         // }
//         // return count;
//     }

//      public static void PrintArray(int[] array)
//     {
//         Console.Write($"{array[0]}");
//         for (int i = 1; i < array.Length; i++)
//         {
//             Console.Write($"\t{array[i]}");
//         }
//         Console.WriteLine();
//         // for (int i = 0; i < array.Length; i++)
//         // {
//         //     Console.Write(array[i]);
//         //     if (i < array.Length - 1) // Проверяем, не последний ли элемент
//         //     {
//         //     Console.Write("\t"); // Добавляем табуляцию после всех элементов, кроме последнего
//         //     }
//       }
//         Console.WriteLine();
//     }
//     public static void Main(string[] args)
//     {
//         int[] array;
//         if (args.Length == 0)
//         {
//             array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
//         }
//         else
//         {
//             string[] argStrings = args[0].Split(", ");
//             array = new int[argStrings.Length];
//             for (int i = 0; i < argStrings.Length; i++)
//             {
//                 if (int.TryParse(argStrings[i], out int number))
//                 {
//                     array[i] = number;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
//                     return;
//                 }
//             }
//         }
//         Console.WriteLine("Массив:");
//         PrintArray(array);
//         int evenCount = CountEvenElements(array);
//         Console.WriteLine($"Количество четных элементов: {evenCount}");
//     }
// }



//         // Программа, находит сумму эл. с нечетными инд. в одномерном массиве
//         // целых чисел и выводит результат на экран. Программа должна иметь
//         // метод SumOddElements, который принимает массив целых чисел и возвращает
//         // сумму элементов с нечетными индексами в массиве. Программа должна
//         // иметь метод PrintArray, который выводит элементы массива на экран. При
//         // выводе элементы массива должны быть разделены символом табуляции "\t".

// using System;

// public class Answer
// {
//     public static int SumOddElements(int[] array)
//     {
//         int sum = 0;
//         for (int i = 1; i < array.Length; i=i+2)
//         {
//             sum += array[i];
//         }
//         return sum;
//     }

//     public static void PrintArray(int[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//         {
//             Console.Write(array[i]);
//             if (i < array.Length - 1)
//             {
//                 Console.Write("\t");
//             }
//         }
//         Console.WriteLine();
//     }

//     public static void Main(string[] args)
//     {
//         int[] array;
//         if (args.Length == 0)
//         {
//             array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
//         }
//         else
//         {
//             string[] argStrings = args[0].Split(", ");
//             array = new int[argStrings.Length];
//             for (int i = 0; i < argStrings.Length; i++)
//             {
//                 if (int.TryParse(argStrings[i], out int number))
//                 {
//                     array[i] = number;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
//                     return;
//                 }
//             }
//         }

//         PrintArray(array);
//         int sumOdd = SumOddElements(array);
//         Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
//     }
// }



        // Программа для работы с массивом вещественных чисел. Реализуйте класс
        // ArrayOperations, который содержит следующие статические методы:
        // FindMax(double[] array): Метод принимает на вход массив вещественных
        // чисел array и возвращает максимальное число из массива.

        // FindMin(double[] array): Метод принимает на вход массив вещественных
        // чисел array и возвращает минимальное число из массива.

        // CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход
        // массив вещественных чисел array и возвращает разницу между максимальным
        // и минимальным числами в массиве.

        // PrintArray(double[] array): Метод для вывода массива на экран. Он
        // принимает на вход массив array и выводит его элементы с двумя знаками
        // после запятой через табуляцию.

using System;

public class Answer
{
    public static double FindMax(double[] array)
    {// Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.
        double max = array[0];
        for (int k = 0; k < array.Length; k++)
        {
            if (array[k] > max)
            {
                max = array[k];
            }
        } 
        return max;
    }

    public static double FindMin(double[] array)
    {// Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.
        double min = array[0];
        for (int m = 0; m < array.Length; m++)
        {
            if (array[m] < min)
            {
                min = array[m];
            }
        } 
        return min;
    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {// Метод принимает на вход массив вещественных чисел array и возвращает разницу между максимальным и минимальным числами в массиве.
        double eMax = array[0];
        double eMin = array[0];
        for (int r = 0; r < array.Length; r++)
        {
            if (array[r] > eMax)
            {
                eMax = array[r];
            }
            if (array[r] < eMin)
            {
                eMin = array[r];
            }
        }
        return eMax-eMin;
    }

    public static void PrintArray(double[] array)
    {// Метод для вывода массива на экран. Он принимает на вход массив array и выводит его элементы с двумя знаками после запятой через табуляцию.
        for (int p = 0; p < array.Length; p++)
        {
            string element = string.Format("{0:F2}", array[p]);
            Console.Write(element);
            if (p < array.Length-1) 
            {
                Console.Write("\t");
            }
        }  
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }
        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}