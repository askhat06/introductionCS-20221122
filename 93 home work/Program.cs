/*Задача 93: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/
int[,] Random2DArray(int n,int m,int min=0,int max=10)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}


int[,] Random2DDArray(int n,int m,int min=0,int max=10)
{
    int[,] b=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                b[i,j]=random.Next(min,max+1);
    return b;
}
void Print2DDArray(int[,] b)
{
    for(int i=0;i<b.GetLength(0);i++)
        {
     for(int j=0;j<b.GetLength(1);j++)
        System.Console.Write($"{b[i,j],4}");
           System.Console.WriteLine();
        }
}
void PrintSumm(int[,] a, int[,] b)
{
    for(int i=0;i<b.GetLength(0);i++)
        {
        for(int j=0;j<b.GetLength(1);j++)
            {
                System.Console.Write($"{a[i,j]*b[i,j],4}");
            }
            System.Console.WriteLine();
        }
}

int[,] a=Random2DArray(5,5);
Print2DArray(a);
System.Console.WriteLine();
int[,] b=Random2DDArray(5,5);
Print2DDArray(b);
System.Console.WriteLine();
PrintSumm(a,b);


/*void PrintSumm(int[,] b, int[,] a)
{
    for(int i=0;i<b.GetLength(0);i++)
        {
     for(int j=0;j<b.GetLength(1);j++)
     {
      for(int c=0;c<a.GetLength(0);i++)
        {
       for(int v=0;v<a.GetLength(1);j++)
           System.Console.Write($"{a[c,v]*b[i,j],4}");
        }
     }
           System.Console.WriteLine();
        }
}*/