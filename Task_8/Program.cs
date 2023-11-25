Console.Clear();

Console.WriteLine("Введите кол-во строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во солбцев:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray()
{
    int[,] array = new int[rows,columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
    return array;
}

//         // Напишите программу для работы с матрицей целых чисел.
//         // Реализуйте класс MatrixOperations, который содержит
//         // следующие статические методы:
//         // PrintMatrix(int[,] matrix): Метод для вывода матрицы на
//         // экран. Он принимает на вход двумерный массив целых чисел
//         // matrix и выводит его элементы в виде таблицы.
//         // SortRowsDescending(int[,] matrix): Метод для сортировки
//         // строк матрицы по убыванию. Он принимает на вход двумерный
//         // массив целых чисел matrix и сортирует каждую строку
//         // матрицы так, чтобы элементы в каждой строке шли по убыванию.

// // int[,] matrix = new int[3,3]; // не могу понять как задать пользовательский массив
// //     if (args.Length == 0)
// //     {
// //          matrix = new int[,] {
// //             {5, 2, 9},
// //             {8, 1, 4},
// //             {6, 7, 3}
// //             };
// //     }

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}

// void SortRowsDescending(int[,] matrix) // Сортирует строки по убыванию
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
//                     int temp = matrix[i, k + 1];
//                     matrix[i, k + 1] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] result = CreateArray();
// PrintMatrix(result);
// SortRowsDescending(result);
// System.Console.WriteLine();
// PrintMatrix(result);



//         // Напишите программу для работы с матрицей целых чисел. Реализуйте
//         // класс Answer, который содержит следующие статические методы:

//         // SumOfRow(int[,] matrix, int row): Метод для вычисления суммы
//         // элементов в заданной строке row матрицы matrix. Метод принимает
//         // двумерный массив целых чисел matrix и номер строки row, а возвращает
//         // целое число - сумму элементов в данной строке.

//         // MinimumSumRow(int[,] matrix): Метод для определения строки с
//         // наименьшей суммой элементов. Метод принимает двумерный массив целых
//         // чисел matrix и возвращает массив из двух элементов: номер строки с
//         // наименьшей суммой (нумерация начинается с 0) и саму сумму.

// int SumOfRow(int[,] matrix, int row)
// {
//     int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[row, j];
//         }
//         return sum;
// }

// int[] MinimumSumRow(int[,] matrix)
// {
//     int[] RowNumberAndSum = new int[2];
//         RowNumberAndSum[1] = SumOfRow(matrix, RowNumberAndSum[0]);
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             if (RowNumberAndSum[1] > SumOfRow(matrix, i))
//             {
//                 RowNumberAndSum[0] = i;
//                 RowNumberAndSum[1] = SumOfRow(matrix, RowNumberAndSum[0]);
//             }
//         }
//         return RowNumberAndSum;
// }


// int[,] result = CreateArray();
// PrintMatrix(result);
// System.Console.WriteLine();

// int[] minSumRow = MinimumSumRow(result);
// Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");

// int rowToSum = 1; 
// int sum = SumOfRow(result, rowToSum);
// Console.WriteLine($"Сумма элементов в строке {rowToSum + 1}: {sum}");




// Реализуйте класс MatrixOperations, который содержит следующие
// статические методы:

// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для
// проверки, возможно ли умножения двух матриц matrixA и matrixB.
// Если число столбцов в матрице matrixA не равно числу строк в матрице
// matrixB, то выводится сообщение "It is impossible to multiply."
// В противном случае, вызывается метод MatrixMultiplication для
// умножения матриц, и результат выводится с помощью метода PrintMatrix.

// MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для
// умножения двух матриц matrixA и matrixB. Метод возвращает новую
// матрицу, которая представляет собой результат умножения матрицы
// matrixA на матрицу matrixB.

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.

// Если аргументы не переданы, программа использует матрицы по
// умолчанию. Если аргументы переданы, программа парсит их в двумерные
// массивы целых чисел и выполняет умножение матриц.

void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("It is impossible to multiply.");
    }
    else  {MatrixMultiplication(matrixA, matrixB);}
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int [,] matrixC = new int [matrixA.GetLength(0),matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int f = 0; f < matrixA.GetLength(1); f++)
            {
                matrixC[i,j] += matrixA[i,f] * matrixB[f,j];
            }
        }
    }
    PrintMatrix(matrixC);
    return matrixC;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

