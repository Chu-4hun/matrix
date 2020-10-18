using System;

namespace Matrix1
{
    public class Task7
    {
        public static void task7()
        {
            Console.WriteLine("Задание 7");
            Console.Write("Введите количество строк в матрице: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в матрице: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[M, N];
            Random rand = new Random();
            Console.WriteLine("\nНачальная матрица");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i, j] = rand.Next(-10, 10);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nОбработанная матрица");
            int k = 0;
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < M; i++)
                {
                    if (arr[i, j] > 0) k++;
                    if (k == M)
                    {
                        for (int l = 0; l < M; l++)
                        {
                            arr[l, j] = 0;
                        }

                        break;
                    }
                }

                if (k < M) k = 0;
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}