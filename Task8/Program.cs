// //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
 Console.Write("Введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());

 int NumberA = 2;

 if(number > 1)
 {
     while(NumberA <= number)
     {
         Console.Write(NumberA + " ");
         NumberA = NumberA + 2;
     }
 }