﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine(getAvg([1,2,3,4,5,5]));
Console.WriteLine(GetMax([1, 2, 3, 4, 7, 5]));
return;

static int GetMax(int[] arr)
{
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }    
    }    return max;
}

static double getAvg(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return (float)sum / arr.Length;
}