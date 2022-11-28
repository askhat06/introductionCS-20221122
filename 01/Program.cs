/*Console.WriteLine("Hello, World!");
System.Console.WriteLine();
int a-0, s=0, d=0,//целый
float f=20.4,//32 
double d=3.14,//вещественныйб 64 бит
*/
//С клавиатуры вводится целое число. Вывести квадрат числа 
internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        System.Console.Write("Введите число:");
        string? s = Console.ReadLine();
        a = Convert.ToInt32(s);
        int b = a * a;
        Console.WriteLine($"{a}^2={b}");
 
    }
}