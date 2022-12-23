//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}
int SumEvenPositions(int[] a)
{
   
    int k=1;
    for(int i=1;i<a.Length;i+=2)
     k++;
    return k;
}
int SumOddPositions(int[] a)
{
    int k=0;
    for(int i=1;i<a.Length;i+=2)
     k++;
     return k;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}
int[] a=RandomIntArray(5,0,5);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Не четные {SumOddPositions(a)}");
System.Console.WriteLine($"Четные {SumEvenPositions(a)}");
