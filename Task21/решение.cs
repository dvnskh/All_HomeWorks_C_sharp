double Length(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = ((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    double check = Math.Sqrt(result);
    return check;
}
System.Console.WriteLine("Введите первую координату точки x1");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите вторую координату x2");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите первую координату точки y1");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите вторую координату точки y2");
double y2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите первую координату точки z1");
double z1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите вторую координату точки z2");
double z2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"расстояние между точками составит +{Length(x1, x2, y1, y2, z1, z2)}");