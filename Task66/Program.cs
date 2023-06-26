// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.Write("Введите натуральное число M: ");
// double numberM = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите натуральное число N: ");
// double numberN = Convert.ToDouble(Console.ReadLine());
// double sum = Sum(numberN,numberM);
// Console.WriteLine(sum);


// double Sum(double numN, double numM)
// {
    
//     if (numN == numM) return numN;
//     else if (numN>numM) return  numN + Sum(numN - 1, numM);
//     else return numM + Sum(numM - 1, numN);
// }
  
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int result = Ackermann(m, n);
Console.WriteLine($"Результат функции Аккермана для {m} и {n} = {result}");

int Ackermann(int m, int n)
{
    if (m == 0)
        return (n + 1);
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ackermann(m - 1, Ackermann(m, n - 1));
    else
    return -1;
}