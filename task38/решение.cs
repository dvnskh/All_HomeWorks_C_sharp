// Задайте массив вещественных случайных чисел. Найдите разницу между максимальным и минимальным элементов массива
void FillArray(double[] array)
{
    int end=100, begin=0;
    for (int i = 0; i <array.Length; i++)
    array[i]= Math.Round(new Random().NextDouble()*(end-begin)+begin,2);
}
void PrintArray(double[] array)
{
foreach (var item in array)
{
Console.Write($"{item} ");
}
System.Console.WriteLine();
}
void FindMax(double[] array)
{   
    double result;
    double max = array[0];
    double min = array[0];
       for (int i = 0; i < array.Length; i++)
       
         if (array[i]>max)
       {
         max=array[i];        
       if (array[i]<min)
       {
        min=array[i];
       }
       }
       result=max-min;
       
      
    System.Console.WriteLine("Максимальный элемент: " + max);
    System.Console.WriteLine("Минимальный элемент: " + min);
    System.Console.WriteLine("Разница между максимальным и минимальным: " +result );
    
}
Console.Clear();
System.Console.WriteLine("Введите количество элементов массива: ");
 int size=Convert.ToInt32(Console.ReadLine());
 double [] array= new double[size];
 FillArray(array);
 PrintArray(array);
 FindMax(array);