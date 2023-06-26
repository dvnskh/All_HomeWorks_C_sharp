// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите натуральное число M: ");
double numberM = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
double numberN = Convert.ToDouble(Console.ReadLine());
double sum = Sum(numberN,numberM);
Console.WriteLine(sum);


double Sum(double numN, double numM)
{
    
    if (numN == numM) return numN;
    else if (numN>numM) return  numN + Sum(numN - 1, numM);
    else return numM + Sum(numM - 1, numN);
}