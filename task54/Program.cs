// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
System.Console.WriteLine("Введите количество строк первой матрицы: ");
int lines = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов первой матрицы: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[lines,cols];
FillArray(array);
PrintArray(array);
sorting(array);
System.Console.WriteLine();
PrintArray(array);


void FillArray(int[,]array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j <array.GetLength(1); j++)
                {
                    array [i,j]=random.Next(0,10);
                }
    }
    
}
void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        
           
        {
            Console.Write(array[i, j] +"\t");
           
        }System.Console.WriteLine();
    }
}

void sorting(int[,]array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            if (array [i,k]<array [i,j])
            (array [i,k],array [i,j])=(array [i,j],array [i,k]);
        }
        // 1,7,9,3,4,2
        // 1,7,3,4,2,9 //один внутренний цикл (пузырьковой сортировки)
        // 1,3,4,2,7,9 // второй цикл

      }  
    }
}
