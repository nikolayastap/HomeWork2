Console.Clear();

//         // Задача 1
//         // Задайте двумерный массив размером m×n, заполненный случайными
//         // вещественными числами.

//         // Внутри класса Answer напишите метод CreateRandomMatrix, который
//         // принимал бы числа m и n (размерность массива), а также
//         // minLimitRandom и maxLimitRandom, которые указывают на минимальную
//         // и максимальную границы случайных чисел.

//         // Также, задайте метод PrintArray, который выводил бы массив на экран.

//         // Для вывода матрица используйте интерполяцию строк для форматирования
//         // числа matrix[i, j] с двумя знаками после запятой (f2) и добавления
//         // символа табуляции (\t) после каждого элемента матрицы. Таким
//         // образом, каждый элемент матрицы будет разделен символом табуляции
//         // при выводе.

// Console.WriteLine("Введите кол-во сток:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцев:");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите минимальную границы случайных чисел:");
// int minLimitRandom = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальную границы случайных чисел:");
// int maxLimitRandom = Convert.ToInt32(Console.ReadLine());

// double[,] CreateRandomMatrix()
// {
//     double[,] matrix = new double[m,n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().NextDouble() + new Random().Next(minLimitRandom,maxLimitRandom +1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j]:f2}\t ");
//         }
//         System.Console.WriteLine();
//     }
// }
// Console.WriteLine($"m = {m}, n = {n}, minLimitRandom = {minLimitRandom}, maxLimitRandom = {maxLimitRandom}");
// Console.WriteLine();

// double[,] matrixResult = CreateRandomMatrix();
// PrintArray(matrixResult);



//         // Задача 2
//         // Внутри класса Answer напишите методы CreateIncreasingMatrix,
//         // PrintArray, FindNumberByPosition и PrintCheckIfError.

//         // Метод CreateIncreasingMatrix должен создавать матрицу заданной
//         // размерности, с каждым новым элементом увеличивающимся на определенное
//         // число. Метод принимает на вход три числа (n - количество строк
//         // матрицы, m - количество столбцов матрицы, k - число, на которое
//         // увеличивается каждый новый элемент) и возвращает матрицу,
//         // удовлетворяющую этим условиям.

//         // Метод PrintArray должен выводить на экран сгенерированную методом
//         // CreateIncreasingMatrix матрицу. Элементы матрицы должны быть
//         // выведены через символ табуляции для более читаемого вывода.

//         // Метод FindNumberByPosition принимает на вход сгенерированную
//         // матрицу и числа x и y - позиции элемента в матрице. Если указанные
//         // координаты находятся за пределами границ массива, метод должен
//         // вернуть массив с нулевым значением. Если координаты находятся в
//         // пределах границ, метод должен вернуть массив с двумя значениями:
//         // значением числа в указанной позиции, а второй элемент должен быть
//         // равен 0, чтобы показать, что операция прошла успешно без ошибок.

//         // Метод PrintCheckIfError должен принимать результат метода
//         // FindNumberByPosition и числа x и y - позиции элемента в матрице.
//         // Метод должен проверить, был ли найден элемент в матрице по указанным
//         // координатам (x и y), используя результаты из метода
//         // FindNumberByPosition. Если такого элемента нет, вывести на
//         // экран "There is no such index". Если элемент есть, вывести на
//         // экран "The number in [{x}, {y}] is {значение}".

// Console.WriteLine("Введите кол-во сток:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцев:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число, на которое увеличивается каждый новый элемент:");
// int k = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату x:");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y:");
// int Y = Convert.ToInt32(Console.ReadLine());

// int[,] CreateIncreasingMatrix()
// {
//     int[,] matrix = new int[n,m];
//     int sum = 1;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = sum;
//             sum = sum + k;
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[] FindNumberByPosition(int [,] matrix, int rowPosition, int columnPosition)
// {
//     if(rowPosition>matrix.GetLength(0) || columnPosition>matrix.GetLength(1))
//     {
//         int[] array = {0};
//         return array;
//     }
//     else
//     {
//         int sum = matrix[rowPosition, columnPosition];
//         int[] array = {sum, 0};
//         return array;
//     }
// }

// void PrintCheckIfError(int[] results, int X, int Y)
// {
//     int i = results[0];
//     if (i != 0) 
//     {
//         System.Console.WriteLine($"The number in [{X}, {Y}] is {i}");
//     }
//     else
//     {
//         System.Console.WriteLine("There is no such index");
//     }
// }

// int[,] result = CreateIncreasingMatrix();
// PrintArray(result);
// PrintCheckIfError(FindNumberByPosition(result, X, Y), X, Y);



        // Задача 3
        // Внутри класса Answer напишите методы CreateIncreasingMatrix,
        // PrintArray, PrintListAvr и FindAverageInColumns.

        // Метод CreateIncreasingMatrix должен создавать матрицу заданной
        // размерности, с каждым новым элементом увеличивающимся на определенное
        // число. Метод принимает на вход три числа (n - количество строк
        // матрицы, m - количество столбцов матрицы, k - число, на которое
        // увеличивается каждый новый элемент) и возвращает матрицу,
        // удовлетворяющую этим условиям.

        // Метод PrintArray должен выводить на экран сгенерированную методом
        // CreateIncreasingMatrix матрицу.

        // Метод FindAverageInColumns принимает целочисленную матрицу типа
        // int[,] и возвращает одномерный массив типа double. Этот метод
        // вычисляет среднее значение чисел в каждом столбце матрицы и
        // сохраняет результаты в виде списка.

        // Метод PrintListAvr принимает одномерный массив, возвращенный
        // методом FindAverageInColumns и выводит этот список на экран в
        // формате
        // The averages in columns are:
        // x.x0 x.x0 x.x0 ..., где x.x0 - это значения средних значений
        // столбцов, округленные до двух знаков после запятой (в дробной
        // части ВСЕГДА должно быть 2 числа через точку, см. формат вывода),
        // разделенные знаком табуляции.

Console.WriteLine("Введите кол-во сток:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцев:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, на которое увеличивается каждый новый элемент:");
int k = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n,m];
    int sum = 1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = sum;
            sum = sum + k;
        }
    }
    return matrix;
}

void PrintListAvr (double [] list)
{
    System.Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < list.Length; i++)
    {
        System.Console.Write($"{list[i]:f2}\t");
    }
}

double [] FindAverageInColumns (int [,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[j,i];
        }
        double average = sum/matrix.GetLength(0);
        array[i] = average;
    }
    return array;
}

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));