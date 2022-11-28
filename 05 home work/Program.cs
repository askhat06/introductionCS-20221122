//С клавиатуры вводятся три числа. Найти максимальное из трех чисел
System.Console.WriteLine("Введите число а:");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число c:");
int c=Convert.ToInt32(Console.ReadLine());
int max=a;
if (a>b) max=a;
if (b>a) max=b;
if (c>max) max=c;
{
 System.Console.WriteLine($"Наибольшее:{max}");
}