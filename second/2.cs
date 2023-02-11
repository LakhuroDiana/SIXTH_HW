float x, y, b1, b2, k1, k2;
System.Console.WriteLine("Введите b1");
b1=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите b2");
b2=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите k1");
k1=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите k2");
k2=Convert.ToInt32(Console.ReadLine());

if (k1==k2)
{
System.Console.WriteLine("Прямые не пересекаются");
}
else
{
x = ((b2 - b1) / (k1 - k2));
y = k1*x+b1;
System.Console.WriteLine($"({x};{y})");
}