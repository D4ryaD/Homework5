// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Console.Write("Введите размер матрицы через пробел: ");
// int[] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);

// Console.Write("Введите строку искомого элемента: ");
// int line = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите строку искомого элемента: ");    
// int column = Convert.ToInt32(Console.ReadLine());
// if (line <= matrix.GetLength(0) - 1 || column<=matrix.GetLength(1) - 1)
// {
//    Console.WriteLine($"значение элемента {line} строки и {column} столбца равно {matrix[line-1,column-1]}");
//     }
// else
// {
//     Console.WriteLine("такого элемента нет");
// }

// PrintMatrix(matrix);

// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//      for(int j = 0; j < matrix.GetLength(0); j++)
//         matrix[i, j] = new Random().Next(1, 100);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for(int j = 0; j < matrix.GetLength(0); j++)
//             Console.Write(matrix[i, j] + "\t");
//         Console.WriteLine();
//     }
// }

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// int[,] array = {
//            {4, 3, 1},
//            {2, 6, 9},
//            {4, 6, 2}
//        };

//        Console.WriteLine("Исходный массив:");
//        PrintArray(array);

//        SwapFirstAndLastRow(array);

//        Console.WriteLine("Массив после замены:");
//        PrintArray(array);
    

//    static void SwapFirstAndLastRow(int[,] array)
//    {
//        int rows = array.GetLength(0);
//        int cols = array.GetLength(1);

       
//        int[] temp = new int[cols];
//        for (int i = 0; i < cols; i++)
//        {
//            temp[i] = array[0, i];
//        }
//        for (int i = 0; i < cols; i++)
//        {
//            array[0, i] = array[rows - 1, i];
//        }

//         for (int i = 0; i < cols; i++)
//        {
//           array[rows - 1, i] = temp[i];
//        }
//    }

//    static void PrintArray(int[,] array)
//    {
//        for (int i = 0; i < array.GetLength(0); i++)
//        {
//            for (int j = 0; j < array.GetLength(1); j++)
//            {
//                Console.Write(array[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// int Prompt(string message)
// {
// Console.Write(message);
//  int result = Convert.ToInt32(Console.ReadLine());
//  return result;
// }

// int[,] CreateArray(int m, int n)
// {
//  int[,] array = new int[m, n];
//  return array;
// }

// void PrintArray(int[,] array)
// {
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      Console.Write($"{array[i, j]} ");
//    }
//    Console.WriteLine();
//  }
// }

// int[,] FillArrayRandom(int[,] array)
// {
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//     array[i, j] = new Random().Next(1, 10);
//    }
//  }
//  return array;
// }

// int SumRowArray(int[,] array)
// {
//  int[] sumArr = new int[array.GetLength(0)];
//  Console.WriteLine($"Сумма по строкам массива:");
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      sumArr[i] += array[i, j];
//    }
//   Console.WriteLine($"{i + 1} -> {sumArr[i]}");
//  }
//  int minSum = sumArr[0];
//  int minRow = 1;
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    if (sumArr[i] < minSum)
//    {
//      minSum = sumArr[i];
//      minRow = i + 1;
//    }
//  }
//  return minRow;
// }

// int[,] array = CreateArray(Prompt("Введите количество строк: "), Prompt("Введите количество столбцов: "));
// array = FillArrayRandom(array);
// PrintArray(array);
// int row = SumRowArray(array);
// Console.WriteLine($"Наименьшая сумма в строке {row}.");
