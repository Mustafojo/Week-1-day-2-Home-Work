﻿int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a-1; i++)
{
    if(arr[i]>0 && arr[i+1]>0 || arr[i]<0 && arr[i+1]<0)
    {
        System.Console.WriteLine("YES");
        
        return;
    }
 
}
System.Console.WriteLine("NO");