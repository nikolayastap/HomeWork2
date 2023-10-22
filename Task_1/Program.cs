// ЗАДАЧА 1. Напишите метод, который на вход принимает
// два числа и выводит, какое число большее, а какое
// меньшее.

// Console.WriteLine("Введите первое число:");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if(firstNumber == secondNumber)
//     {
//         Console.WriteLine($"Введенные числа равны `{firstNumber}`");
//     }
//     else if(firstNumber < secondNumber)
//     {
//         Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
//     }
//     else
//     {
//         Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
//     }



// ЗАДАЧА 2. Напишите метод, который принимает на вход
// три числа и выдаёт максимальное из этих чисел.

// Console.Write("Введите 1-ое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 3-ое число: ");
// int c = int.Parse(Console.ReadLine()!);
// int Max = a;
// if(Max < b)
//     {
//       Console.WriteLine($"Max = {b}");
//     }
// else if (Max < c)
//     {
//         Console.WriteLine($"Max = {c}");
//     }
// else
//     {
//     Console.WriteLine($"Max = {a}");
//     }



// ЗАДАЧА 3. Hапишите метод, который на вход принимает
// число number и выводит, является ли число чётным
// (делится ли оно на два без остатка).

// Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// if (0 == number % 2)
//     Console.WriteLine($"Число `{number}` чётное");
// else
//     Console.WriteLine($"Число `{number}` нечётное");



// ЗАДАЧА 4. Напишите метод, которая на вход принимает
// число (number), а на выходе выводит все чётные
// числа от 1 до number (включительно), разделеные
// знаком табуляции.

// Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!), i = (0);
// while(i + 2 <= number)
// {
//   i = i + 2;
//   Console.Write($"{i}\t");
// }