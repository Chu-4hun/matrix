﻿using System;

namespace Matrix1
{
    public class task2
    {
        public static void two()
        {
            int[] arr = {1,2,3,4,5,6,7,8,9,10};
            for (int i = 0; i < arr.Length; i += 2)
            {
                arr[i] *= 3;
                Console.WriteLine(arr[i]);
            }
        }
    }
}