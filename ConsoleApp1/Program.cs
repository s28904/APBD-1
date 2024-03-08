// See https://aka.ms/new-console-template for more information
Console.WriteLine(getAvg([1,2,3,4,5,5]));

return;

static double getAvg(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return (float)sum / arr.Length;
}