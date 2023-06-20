// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
Console.Clear();
System.Console.WriteLine("Введите количество строк первой матрицы: ");
int lines = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов первой матрицы: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[lines, cols];
FillArray(array);
PrintArray(array);


System.Console.WriteLine();
// PrintArray(array);


void FillArray(int[,] array)
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
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)


        {
            Console.Write(array[i, j] + "\t");

        }
        System.Console.WriteLine();
    }
}
int minSum = int.MaxValue; //что здесь хранится=>само значение 
int minSumLines = 0;//здесь должен храниться индекс минимальной строки

for (int i = 0; i < array.GetLength(0); i++)
{
    int Sum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        Sum += array[i, j];
     
    }
    if (Sum < minSum)
    {
        minSum=Sum;
        minSumLines=i;
    }
   

}

 System.Console.WriteLine($"Сумма строк равна: {minSum}");
    System.Console.WriteLine($"индекс минимальной суммы строк: {minSumLines}");


