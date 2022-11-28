internal class NewBaseType
{
    private static void Main(string[] args)
    {
        // С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
        // Задачу не смог решить
        Console.WriteLine("Введите число от 10 до 99:");
        int a = Convert.ToInt32(Console.ReadLine());
        int m;
        m = a % 10;
        a = a / 10;
        while (a > 0) ;
        if (a % 10 > m)
        {
            Console.WriteLine(m);
        }
    }
}