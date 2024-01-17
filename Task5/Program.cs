using System.Net.Http.Headers;

int a =Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
int cnt = 0;
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(arr);
for (int i = 0; i < a; i++)
{
    cnt = 0;
    for (int j = 0; j < a; j++)
    {
        if(arr[i] == arr[j] && i != j)
        {
            System.Console.WriteLine(arr[i]);
        }
    }
}


// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// int cnt = 1;
// for(int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 1; i < a; i++)
// {
//     if(arr[i] != arr[i-1])
//     {
//         cnt++;
//     }
// }
// System.Console.WriteLine(cnt);
