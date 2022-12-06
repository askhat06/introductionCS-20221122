// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
System.Console.WriteLine("Введите день недели от 1 до 7:");
int k;
k=Convert.ToInt32(Console.ReadLine());
if (k==7)
System.Console.WriteLine("Этот день является выходным");
else System.Console.WriteLine("Этот день не является выходным");