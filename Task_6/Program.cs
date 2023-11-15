// Console.Clear();

//         // Задача 41. Пользователь вводит с клавиатуры M чисел.
//         // Посчитайте, сколько чисел больше 0 ввёл пользователь.
//         // 0, 7, 8, -2, -2 -> 2;  1, -7, 567, 89, 223-> 3


// Console.Write("Ведите размер массива:");
// int sizeM = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[sizeM];
// int countPosiNum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите элемент массива {i}:\t");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

// Console.Write("Вывод массива: ");

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + ", ");

//     if (array[i] > 0)
//     {
//         countPosiNum++;
//     } 
    
// }
// Console.Write($"Чисел больше 0: {countPosiNum}");




        // Задача 43. Программа, находит точку пересечения двух
        // прямых, заданных уравнениями y = k1 * x + b1,
        // y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
        // пользователем.
        // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double k1, b1, k2, b2;

Console.WriteLine("Введите значения b1, k1, b2 и k2:");


Console.Write("b1: ");
b1 = double.Parse(Console.ReadLine());
Console.Write("k1: ");
b1 = double.Parse(Console.ReadLine());
Console.Write("b2: ");
b2 = double.Parse(Console.ReadLine());
Console.Write("k2: ");
k2 = double.Parse(Console.ReadLine());


if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны и не пересекаются.");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
}

