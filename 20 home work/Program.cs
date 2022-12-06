// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y
int x,y;
x=Convert.ToInt32(Console.ReadLine());
y=Convert.ToInt32(Console.ReadLine());
if  (x>0 & y>0)
    System.Console.WriteLine("1");
if (x>0 & y<0)
    System.Console.WriteLine("4");
if (x<0 & y<0)
    System.Console.WriteLine("2");
if (x<0 & y<0)
    System.Console.WriteLine("3");