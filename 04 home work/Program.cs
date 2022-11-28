// По заданному с клавиатуры номеру дня недели вывести его название
System.Console.WriteLine("Введите день недели от 1 до 7:");
int k;
k=Convert.ToInt32(Console.ReadLine());
if (k==1)
System.Console.WriteLine("Понедельник");
if (k==2)
System.Console.WriteLine("Вторник");
if (k==3)
System.Console.WriteLine("Среда");
if (k==4)
System.Console.WriteLine("Четверг");
if (k==5)
System.Console.WriteLine("Пятница");
if (k==6)
System.Console.WriteLine("Субота");
if (k==7)
System.Console.WriteLine("Воскресенье");