// Задача 10: Программа, принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5, 782 -> 8, 918 -> 1.

// Console.Clear();
// Console.Write("Введите трёхзначенное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 100 || n > 999)
//   {
//     Console.Write(" Вы ошиблись! \n Введите трехзначенное число: ");
//     n = Convert.ToInt32(Console.ReadLine());
//   }
// Console.WriteLine(n / 10 % 10);




// Задача 13. Программа, выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6.

// Console.Clear();
// Console.Write("Введи число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string numberText = Convert.ToString(number);
// if (numberText.Length > 2)
// {
//   Console.WriteLine("третья цифра -> " + numberText[2]);
// }
// else {
//   Console.WriteLine("-> третьей цифры нет");
// }



// Задача 15. Программа, принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
// 6 -> да, 7 -> да, 1 -> нет.

Console.Clear();
Console.Write("Введите день недели: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1 || n > 7)
{
  Console.Write(" Вы ошиблись! \n Введите день недели: ");
  n = int.Parse(Console.ReadLine()!);
}
if (n > 5)
  Console.WriteLine("Да");
else
  Console.WriteLine("Нет");