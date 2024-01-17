int a;
int b = 1;
for (;;)
{
    a = Convert.ToInt32(Console.ReadLine());

    if (a == 0) break;
    b = a;
        
}
System.Console.WriteLine(b);