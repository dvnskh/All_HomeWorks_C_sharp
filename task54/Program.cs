// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
  Console.Clear();
System.Console.WriteLine("Введите количество строк первой матрицы: ");
int lines = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов первой матрицы: ");
int сols = Convert.ToInt32(Console.ReadLine());
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
System.Console.WriteLine("Введите количество строк второй матрицы: ");
int lines1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов второй матрицы: ");
int сols1 = Convert.ToInt32(Console.ReadLine());
void FillArray2(int[,]array)
{
    Random random = new Random();
    for (int n = 0; n < array.GetLength(0); n++)
    { 
        for (int m = 0; m <array.GetLength(1); m++)
                {
                    array [n,m]=random.Next(0,10);
                }
    }
               
}

void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            for (int n = 0; n <array.GetLength(0); n++)
            {
                for (int m = 0; m < array.GetLength(1); m++)
        {
            Console.Write(array[i, j] +"\t");
            Console.Write(array[n, m]+"\t");
        }
    }
}

void PrintArray2(int[,]array)
{
    
    {
        
        
            for (int n = 0; n <array.GetLength(0); n++)
            {
                for (int m = 0; m < array.GetLength(1); m++)
        {
            ;
            Console.Write(array[n, m]+"\t");
        }
    }
}

 int noName(int [,]array)
{       
    for (int i = 0; i < array.GetLength(0); i++)
    {  
              
        for (int j =0; j <array.GetLength(1); i++)
    {
        for (int n = 0; n < array.GetLength(0); n++)
        {
            for (int m = 0; m < array.GetLength(1); m++)
            {
               int result1 = (i*n+i*m)+(i*n+1+i*m+1);
               int result2 = (j*n+j*m)+(j*n+1+j*m+1);     
              return result1;
              return result2;
            }
            
        
    }

       
        
     
}
  FillArray(array);
        FillArray2(array);
        PrintArray(array);
        PrintArray2(array);
        Console.WriteLine();
        noName(array);
       
      
      
    }
}}}}


// class Program
// {
//     static void Main()
//     {
//         Console.Clear();
//         Console.WriteLine("Введите количество строк первой матрицы: ");
//         int lines = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Введите количество столбцов первой матрицы: ");
//         int cols = Convert.ToInt32(Console.ReadLine());
//         int[,] array = new int[lines, cols];

//         Console.WriteLine("Введите количество строк второй матрицы: ");
//         int lines1 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Введите количество столбцов второй матрицы: ");
//         int cols1 = Convert.ToInt32(Console.ReadLine());
//         int[,] array2 = new int[lines1, cols1];

//         FillArray(array);
//         FillArray2(array2);
//         Console.WriteLine("Первая матрица:");
//         PrintArray(array);
//         Console.WriteLine("Вторая матрица:");
//         PrintArray2(array2);

//         Console.WriteLine();
//         NameNo(array);
//     }

//     static void FillArray(int[,] array)
//     {
//         Random random = new Random();
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = random.Next(0, 10);
//             }
//         }
//     }

//     static void FillArray2(int[,] array)
//     {
//         Random random = new Random();
//         for (int n = 0; n < array.GetLength(0); n++)
//         {
//             for (int m = 0; m < array.GetLength(1); m++)
//             {
//                 array[n, m] = random.Next(0, 10);
//             }
//         }
//     }

//     static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + "\t");
//             }
//             Console.Write();
//         }
//     }

//     static void PrintArray2(int[,] array)
//     {
//         for (int n = 0; n < array.GetLength(0); n++)
//         {
//             for (int m = 0; m < array.GetLength(1); m++)
//             {
//                 Console.Write(array[n, m] + "\t");
//             }
//             Console.Write();
//         }
//     }

//     static void NameNo(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 for (int n = 0; n < array.GetLength(0); n++)
//                 {
//                     for (int m = 0; m < array.GetLength(1); m++)
//                     {
//                         int result1 = (i * n + i * m) + (i * n + 1 + i * m + 1);
//                         int result2 = (j * n + j * m) + (j * n + 1 + j * m + 1);
//                         Console.Write("result1: " + result1 + ", result2: " + result2);
//                     }
//                 }
//             }
//         }
//     }
// }