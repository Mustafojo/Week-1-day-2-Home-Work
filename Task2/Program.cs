int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
double sum = 1;

for (int i = 1; i <= b; i++)
{
    sum += Math.Pow(a,i);
}
System.Console.WriteLine(sum);
