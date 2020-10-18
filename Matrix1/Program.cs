using System;
using System.Threading;
using static Matrix1.task1;
using static Matrix1.task2;
using static Matrix1.task3;
using static Matrix1.task4;
using static Matrix1.TreeNode;



namespace Matrix1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            one();
            Thread.Sleep(5000);
            Console.Clear();
            two();
            Thread.Sleep(5000);
            Console.Clear();
            three();
            Thread.Sleep(5000);
            Console.Clear();
            four();
            Thread.Sleep(5000);
            Console.Clear();
            Console.Write("n = ");
                var n = int.Parse(Console.ReadLine());
                var a = new int[n];
                var random = new Random();
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = random.Next(0, 100);
                }

                Console.WriteLine("Random Array: {0}", string.Join(" ", a));

                Console.WriteLine("Sorted Array: {0}", string.Join(" ", TreeSort(a)));
            
            Thread.Sleep(5000);
            Console.Clear();
            task6();
        }

        static void task6()
        {
            Console.WriteLine("arr lenght NxM");
            int n, m, i, j;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, m];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int sum1 = 0;
 
            for (i = 1; i < n; i++)//перебираем столбцы
            {
 
                for (j = 1; j < m - 1; j++)//перебираем элементы столбца
                {
                    if (mat[i, j] == mat[i, j + 1])
                        break;
                }
                if (j == m - 1)
                    sum1 = sum1 + 1;
 
            }
            int sum2 = 0;
            for (j = 1; j < m; j++)//перебираем строки
            {
 
                for (i = 1; i < n - 1; i++)//перебираем элементы строк
                {
                    if (mat[i, j] == mat[i-1, j])
                        break;
                }
                if (i == n - 1)
                    sum2 = sum2 + 1;
                
            }
            Console.WriteLine("count of difference {0}", sum1, "Количество строк, все элементы которых различны{0}", sum2);
        }

        static void task7()
        {
            
        }
    }
}