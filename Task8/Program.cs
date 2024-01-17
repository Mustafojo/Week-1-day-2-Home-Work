int a = Convert.ToInt32(Console.ReadLine());
int cnt = 1;
int sum = 0;
for (int i = a; i>0; i/=10)
{
    sum +=i%10;
    cnt *=i%10;
}
System.Console.WriteLine("SUM = " + sum);
System.Console.WriteLine("ZARB = " + cnt);

