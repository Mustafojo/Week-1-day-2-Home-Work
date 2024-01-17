int a;
int b = 1;
int sum = 0;
for (;;)
{
    a = Convert.ToInt32(Console.ReadLine());
    sum += a;
    if (a == 0 && b == 0) break;
    b = a;
        
}
System.Console.WriteLine(sum);