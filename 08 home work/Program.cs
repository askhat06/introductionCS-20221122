// Вывести на экран числа от -N до N
System.Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= N)
{
   Console.Write($"{i}  ");
   i = i + 1;
}