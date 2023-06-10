void FillArray(int[] array)
{
   
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100,1000);
}
}

void PrintArray(int[] array)
{
foreach (var item in array)
{
Console.Write($"{item} ");
}
System.Console.WriteLine();
}

void FindSums(int[] array)
{
    
   int evenCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                evenCount++;
            }
        }
    
System.Console.WriteLine($"Количество четных элементов массива равно " + evenCount);

}
Console.Clear();
System.Console.WriteLine("введите количество трехзначных цифр в массиве");
int size=Convert.ToInt32(Console.ReadLine());
int [] array= new int[size];
FillArray(array);
PrintArray(array);
FindSums(array);
