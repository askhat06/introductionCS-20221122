internal class Program
{
    private static void Main(string[] args)
    {
        // Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
        Console.WriteLine("Введите число:");
        int n, y;     
        n = Convert.ToInt32(Console.ReadLine());
        y = n % 10;
        Console.WriteLine("Последнее число{0,5}", +y);
    }
}