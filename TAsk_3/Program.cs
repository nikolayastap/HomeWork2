//Console.Clear();

    // Прщграмма принимает на вход пятизначное число number и
    // проверяет, является ли оно палиндромом. Метод должен 
    // проверить является ли число пятизначным, в противном
    // случае - вывести Число не пятизначное и False в следующей
    // строке. Для остальных чисел вернуть True или False.

// Console.Write("Введите пятизначное число: ");
// string number = Console.ReadLine()!;
// if (number.Length != 5)
// {
//     Console.WriteLine("Число не пятизначное \n  False");
// }
// else if (number[0] == number[4] && number[1] == number[3])
// {
//     Console.WriteLine("True");
// }
// else 
// {
//     Console.WriteLine("False");
// }


// НЕОБХОДИМО ЕЩЕ РАЗ ПРОРАБОТАТЬ
    // Вариант 2 (Для автотеста) 
// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//       // Введите свое решение ниже
//       bool resultCheck = true;
//       if (number / 10000 > 0 && number / 10000 < 10) 
//       {
//        if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10) resultCheck = true;
//        else resultCheck = false;
//       }
//       else 
//       {
//         System.Console.WriteLine("Число не пятизначное");
//         resultCheck = false;
//       }
//         return resultCheck;
//     }
  
//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 14212;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }



        // Программа принимает на вход координаты двух точек
        // pointA и pointB в виде массива целых чисел, и возвращает
        // расстояние между ними в 3D пространстве

// Console.Write("Координаты pointA по оси x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Координаты pointA по оси y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Координаты pointA по оси z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Координаты pointB по оси x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Координаты pointB по оси y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Координаты pointB по оси z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double s= Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));

// Console.WriteLine($"Растояние между точками: {Math.Round(s,2)}");



    // Вариант 2 (для автотеста)
// using System;

// public class Answer
// {
//     private static double Length(int[] pointA, int[] pointB)
//     {
//       // Введите свое решение ниже

//     double distens = Math.Sqrt(Math.Pow((pointA[0]-pointB[0]),2) + Math.Pow((pointA[1] - pointB[1]),2) + Math.Pow((pointA[2] - pointB[2]),2)); 
//     return distens;
//     }

//   // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args) {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6) {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 3;
//             x2 = 6;
//             x3 = 8;
//             y1 = 2;
//             y2 = 1;
//             y3 = -7;
//         }

//         // Не удаляйте строки ниже
//         double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
//         Console.WriteLine($"{result:F2}");
//     }
// }




        // Программа принимает на вход число (N) и выводит таблицу
        // кубов чисел от 1 до N(включит.) каждое на новой строке.

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
//   Console.Writeline($"{i * i * i} ");
 
    // Вариант 2
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
//     Console.WriteLine(Math.Pow(i,3));
