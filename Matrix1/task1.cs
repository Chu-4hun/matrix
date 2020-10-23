using System;

namespace Matrix1
{
    public class task1
    {
        public static void one()
        {
            Console.WriteLine("Дан массив размера N. Найти два соседних элемента, \nсумма которых максимальна, и вывести эти элементы в порядке возрастания их индексов.");
            int[] a = {1, 2, 3, 4, 2};
            for (int i = 0; i < a.Length; ++i)
            {
                for (int j=i+1; j<a.Length; ++j)
                    if(a[i]==a[j])
                    {
                        Console.Write(i+" "+j);
                        break;
                    }

            }
            Console.ReadKey();
        }
    }
}