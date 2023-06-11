// задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] Array = new double[m, n];
Random rnd = new Random();
void PrintArray(double[,] array)
{ 
    for (int i = 0; i < m; i++)
 { 
    for (int j = 0; j < n; j++)
 { 
    Console.Write(array [i, j]+"\t");
}
 Console.WriteLine();
 }
}

void FillArray(double[,] array)
{ for (int i = 0; i < m; i++)
    { for (int j = 0; j < n; j++)
 { 
    array[i,j] = Convert.ToDouble(rnd.Next(-1000, 1000)/10.0);
 }
    }
}

FillArray(Array);
Console.WriteLine();
PrintArray(Array);