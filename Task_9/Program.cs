Console.Clear();

//         // Задача 64: Задайте значение N. Напишите программу,
//         // которая выведет все натуральные числа в промежутке
//         // от N до 1. Выполнить с помощью рекурсии.
//         // N = 5 -> "5, 4, 3, 2, 1"
//         // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// System.Console.WriteLine("Введите число N:");
// int num = Convert.ToInt32(Console.ReadLine());

// double lastNum = 1.0;

// string PrintNumber(double start, double end) 
// {
//     if(start==end)
//     {
//         return start.ToString();
//     }
//     return start+ "\t"+ PrintNumber(start-0.5, end);
// }

// if(num > lastNum)
// {
//     Console.WriteLine(PrintNumber(num,lastNum));
// }
// else if(num < lastNum)
// {
//      Console.WriteLine("Ввдите положительное число!");
// }
// else
// {
//     Console.WriteLine("Ввели равные числа");
// }




//         // Задача 66: Задайте значения M и N. Напишите программу,
//         // которая найдёт сумму натуральных элементов в
//         // промежутке от M до N.
//         // M = 1; N = 15 -> 120
//         // M = 4; N = 8. -> 30

// System.Console.WriteLine("Введите число M:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число N:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int SumElements(int num, int end) 
// {
//     if(num == end)
//     {
//         return num;
//     }
//     return SumElements(num+1, end)+ num;
// }

// if(num1 < num2)
// {
//     Console.WriteLine(SumElements(num1, num2));
// }
// else if(num1 > num2)
// {
//      Console.WriteLine(SumElements(num2, num1));
// }
// else
// {
//     Console.WriteLine("Ввели равные числа");
// }



        // Задача 68: Напишите программу вычисления функции
        // Аккермана с помощью рекурсии. Даны два неотрицательных
        // числа m и n.
        // m = 2, n = 3 -> A(m,n) = 9
        // m = 3, n = 2 -> A(m,n) = 2

System.Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");






