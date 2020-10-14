using System;

namespace Matrix1
{
    public class task3
    {
        public static void three()
        {
            int[] arr = {1,2,3,4,5,6,7,-9,-10};
            int sum = 0;
            for (int i = arr.Length - 1; i > 0; i--)
            if (arr[i] > 0)
            {
                for (int j = 0; j < i; j++)
                    sum += arr[j];
                break;
            }
            Console.WriteLine(sum);
            
            
        }
    }
}