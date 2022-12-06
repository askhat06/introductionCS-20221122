// По двум заданным числам проверять является ли одно квадратом другого.
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
if (a*a==b) System.Console.WriteLine($"{b} явл.кв. {a}");
     else
         if (b*b==a) System.Console.WriteLine($"{a} явл.кв. {b}");
             else 
             System.Console.WriteLine("не явл.");