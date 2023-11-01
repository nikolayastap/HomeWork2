Console.Clear();
//         // Задача 25. Цикл принимает на вход два числа (A и B)
//         // и возводит число A в натуральную степень B.

// System.Console.Write("Введите число A: ");
// int numA = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите число B: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// int GetMultiplication()
// {
//         int start = 1;
//         int multiplication = numA;

//         while (start < numB)
//         {
//              multiplication *= numA;
//              start++;
//         }
//         return multiplication;
// }
// Console.WriteLine(GetMultiplication());



//         // Задача 27. Программа принимает на вход
//         // число и выдаёт сумму цифр в числе.

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetSumNum()
// {
//     int sum = 0;

//     while(num > 0)
//     {
//         sum = sum + num %10;
//         num /= 10;
//     }
//     return sum;
// }

// System.Console.WriteLine($"Сумма вех цифр в числе: {GetSumNum()}");



                // Задача 29. Программа задаёт массив из 8 элементов
                // и выводит их на экран.

void CreateArray()
{
        int[] array = new int[8];

        int i = 0;

        while(i < array.Length)
    {
        array[i] = new Random().Next(0, 33);
        System.Console.Write(array[i]+ " ");
        i++;
    }
}
CreateArray();