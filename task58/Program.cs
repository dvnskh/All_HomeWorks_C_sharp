// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4 5
// 3 2 | 3 3 4
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
System.Console.WriteLine("Введите количество строк первой матрицы: ");
int lines = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов первой матрицы: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[lines, cols];
FillArray(array1);
PrintArray(array1);




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

int[,] array2 = new int[lines, cols];
FillArray(array2);
PrintArray(array2);

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
    System.Console.WriteLine();
}
int[,] array3 = new int[lines, cols];
noName(array1, array2, array3);
PrintArray(array3);

void noName(int[,] array1, int[,] array2, int[,] array3)
{


 
    for (int i = 0; i < array3.GetLength(0); i++)
    {

        for (int j = 0; j < array3.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array3.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];

            }
            array3[i, j] = sum;
        }
    }
}

















