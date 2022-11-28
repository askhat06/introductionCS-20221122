// Выяснить является ли число чётным.
  System.Console.WriteLine("Введите число:");
   int n = Convert.ToInt32(Console.ReadLine());
   if (n%2==0)
  {
     Console.Write($"Число четное:{n}");
 }
 if (n%2==1)
 {
  Console.Write($"Число нечетное:{n}");
 }
