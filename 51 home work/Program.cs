// С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры
int N=Convert.ToInt32(Console.ReadLine());
int[] t;
t= new int[N];
for (int i=0;i<N;i++)
     t[i]=Convert.ToInt32(Console.ReadLine());

int Solve(int[] t)
{   
    int count=0;
    foreach(int el in t)
    {
        if (el>0)
            count++;       
    }
    return count;

}
System.Console.WriteLine(Solve(t));