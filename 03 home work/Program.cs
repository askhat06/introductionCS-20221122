//С клавиатуры вводятся два числа a и b. Найти максимальное из них

System.Console.WriteLine("Введите число а:");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
int b=Convert.ToInt32(Console.ReadLine());

if (a>b)
{
 System.Console.WriteLine($"Наибольшее:{a}");
}
if (b>a)
{
 System.Console.WriteLine($"Наибольшее:{b}");
}