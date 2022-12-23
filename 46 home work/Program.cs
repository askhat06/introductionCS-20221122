// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}
int Sum(int[] a)
{
    int k=0;
    for(int i=1;i<a.Length;i++)
        if (a[i]>=10 && a[i]<=90) k++;
    return k;
}
void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}
int[] a=RandomIntArray(10,0,123);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine(Sum(a));
