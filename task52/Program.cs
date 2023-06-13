// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

    static void FillArray(int[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(0, 10);
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j]+"\t");
            }
            Console.WriteLine();
        }
    }

    static void Average(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        for (int j = 0; j < cols; j++)
        {
            double columnSum = 0;
            for (int i = 0; i < rows; i++)
            {
                columnSum += array[i, j];
            }
            double columnAverage = columnSum / rows;
            Console.WriteLine($"Среднее значение в столбце {j}: {columnAverage}");
        }
    }
        Console.Clear();
        Console.WriteLine("Введите количество строк:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов:");
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[rows, cols];
        FillArray(array);
        PrintArray(array);
        Console.WriteLine();
        Average(array);
  
    
       
        
    

