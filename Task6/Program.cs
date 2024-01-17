int a =Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(arr);
for (int i = 0; i < a; i++)
{
    System.Console.WriteLine(arr[0]);
    break;
}