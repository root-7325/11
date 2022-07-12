using System;
class is1greaterthenlast
{
    static void Main()
    {
        int[] arr = new int[3];
        for(int i = 0; i < arr.Length; i++) arr[i] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Does 1st greater than 3rd: " + (arr[0] > arr[2]));
        Console.ReadKey(true);
    }
}   
