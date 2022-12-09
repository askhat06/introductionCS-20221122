// Найти сумму чисел от 1 до А
System.Console.WriteLine("Введите число:");
int A = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= A)
{
   Console.Write($"{i+i} ");
   i = i + 1;
}