using System;

namespace Matrix1
{
    public class task8
    {
        public static void Eight()
        {
            Console.Write("Введите количество столбец: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество строка: ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            int[,] а180 = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    a[i, j] = rnd.Next(0, 100);
                    Console.Write("  " + a[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("при повороте на 180 градусов");
            for (int i = 0, t = n - 1; i < n; i++, t--)
            {
                for (int j = 0, k = m - 1; j < m; j++, --k)
                {
                    а180[i, j] = a[t, k];
                    Console.Write("  " + а180[i, j] + "");
                }
            }
        }
    }
}