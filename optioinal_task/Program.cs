System.Console.WriteLine("Введите количество программистов: ");
int num=Convert.ToInt32(Console.ReadLine());
int num1=num%10;
int num2=num%100;
if (num1==1&num2!=11)
{
    System.Console.WriteLine("Программист");
}
else if (num1==5||num2==11||num2==12||num2==13||num2==14)
    System.Console.WriteLine("Программистов");
else if (num1==2||num1==3||num1==4)
    System.Console.WriteLine("Программиста");
else if (num1>5)
    System.Console.WriteLine("Программистов");