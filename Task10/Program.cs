int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];

for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < a; i++)
{
    int cnt=0;
    for (int j = 2; j < arr[i]; j++)
    {
       if (arr[i] % j == 0)
       {
        cnt++;
       }
    }
    if (cnt!=0)
    {
        System.Console.WriteLine(arr[i]);
    }
}
