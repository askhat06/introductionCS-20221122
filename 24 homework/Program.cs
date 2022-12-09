//Вывести на экран таблицу квадратов чисел от 1 до N
/*int a=Convert.ToInt32(Console.ReadLine());
for(int i=a;i<=a;i++)
    System.Console.WriteLine($"{i}");*/
/*internal class Program
{
    private static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        for (int i = N; i <= N; i++)
            Console.Write($"{i} ");
    }
}*/

System.Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= N)
{
   Console.Write($"{i*i} ");
   i = i + 1;
}
/*System.Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int askhat(int i = 1)
{
while (i <= N)
{
   i = i + 1;
   return i;
}
}

   Console.Write(askhat(i));*/