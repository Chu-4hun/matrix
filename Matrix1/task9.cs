using System;

namespace Matrix1
{
    public class task9
    {
        public static void Task9()
        {
            Console.WriteLine("сортировка змейкой");
            int[] mas = new int[9] {1, 2, 3, 4, 5, 6, 7, 8, 9}; 
            int[,] mtx = new int[3, 3]; 
            int j = 0, k = 0; 
            for (int i = 0; i < 3; i++) 
            { 
                mtx[i, j] = mas[k]; 

                k++; 
            } 

            j++; 
            for (int i = 2; i > -1; i--) 
            { 
                mtx[i, j] = mas[k]; 

                k++; 
            } 

            j++; 
            for (int i = 0; i < 3; i++) 
            { 
                mtx[i, j] = mas[k]; 

                k++; 
            } 

            for (int i = 0; i < 3; i++) 
            { 
                for (j = 0; j < 3; j++) 
                { 
                    Console.Write($"{mtx[i, j]}"); 
                } 
                Console.WriteLine(); 
            }
        }
    }
}