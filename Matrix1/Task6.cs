using System;

namespace Matrix1
{
    public class Task6
    {
        public static void task6()
        {
            Console.WriteLine("Дана целочисленная матрица размера M ´ N. \nНайти количество ее строк, все элементы которых различны");
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

            for (i = 1; i < n; i++) //перебираем столбцы
            {

                for (j = 1; j < m - 1; j++) //перебираем элементы столбца
                {
                    if (mat[i, j] == mat[i, j + 1])
                        break;
                }

                if (j == m - 1)
                    sum1 = sum1 + 1;

            }

            int sum2 = 0;
            for (j = 1; j < m; j++) //перебираем строки
            {

                for (i = 1; i < n - 1; i++) //перебираем элементы строк
                {
                    if (mat[i, j] == mat[i - 1, j])
                        break;
                }

                if (i == n - 1)
                    sum2 = sum2 + 1;

            }

            Console.WriteLine("count of difference {0}", sum1, "Количество строк, все элементы которых различны{0}",
                sum2);
        }
    }
}