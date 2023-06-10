System.Console.WriteLine("Введите цифру обознчающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 6:
    System.Console.WriteLine("Da"); 
    break;
    case 7:
    System.Console.WriteLine("Da");
    break;
    case 1:
    System.Console.WriteLine("Net");
    break;
    default:
    System.Console.WriteLine("не верное значение");
    break;
}