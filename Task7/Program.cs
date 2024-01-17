int a;
 int sum = 0;
 int cnt = 0;
for(;;)
{  
    a = Convert.ToInt32(Console.ReadLine());
    if(a == 0) break;
    sum += a;
    cnt++;

}
System.Console.Write("Total sum of numbers: ");
System.Console.WriteLine(sum);
System.Console.Write("Total amount of numbers: ");
System.Console.WriteLine(cnt);