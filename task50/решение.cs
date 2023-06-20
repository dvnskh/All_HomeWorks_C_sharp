// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
//  и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
                Console.Write($"{array[i, j],3}    ");
            }
            Console.WriteLine();
        }
    }

    static void DoubleNum(int[,] array)
    {
        Console.WriteLine("Введите проверочное число: ");
        int revesor = Convert.ToInt32(Console.ReadLine());
        bool numberFound = false;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == revesor)
                {
                    Console.WriteLine("Такое число есть");
                    numberFound = true;
                    break;
                }
            }

            
        }

        if (!numberFound)
        {
            Console.WriteLine("Такого числа нет");
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
        DoubleNum(array);
        PrintArray(array);
    
