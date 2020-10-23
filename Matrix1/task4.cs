using System;

namespace Matrix1
{
    public class task4
    {
        public static void four()
        {
            Console.WriteLine("Дан массив A размера N. Сформировать новый массив B того же размера по следующему правилу: \n  элемент BK равен сумме элементов массива A с номерами от K до N.");
            Console.WriteLine("enter N");            
            int N = Int32.Parse(Console.ReadLine());
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = i+1;                
            }
            int k = 0;
            int sum = 0;
            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                sum = 0;
                for (k=i; k < N; k++)
                {
                    sum = sum + A[k];
                }
                B[i] = sum;
            }
            Console.Write("Array A \n");
            foreach (int x in A)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\nArray B");
            foreach (int x in B)
            {
                Console.Write(x + " ");
            }
            Console.ReadLine();
        }
    }
}