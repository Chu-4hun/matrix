using System;
using System.Threading;
using static Matrix1.task1;
using static Matrix1.task2;
using static Matrix1.task3;
using static Matrix1.task4;
using static Matrix1.TreeNode;
using static Matrix1.Task6;
using static Matrix1.Task7;
using static Matrix1.task8;
using static Matrix1.task9;


namespace Matrix1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num of rask ");
            SByte Nomer = 0;
            try
            {
                Nomer = Convert.ToSByte(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nEnter numbers - ___-\n");
                throw;
            }

            switch (Nomer)
            {
                case 1:
                    one();
                    break;
                case 2:
                    two();
                    break;
                case 3:
                    three();
                    break;
                case 4:
                    four();
                    break;
                case 5:
                    Console.Write("n = ");
                    var n = int.Parse(Console.ReadLine());
                    var a = new int[n];
                    var random = new Random();
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i] = random.Next(0, 100);
                    }

                    break;
                case 6:
                    task6();
                    break;
                case 7:
                    task7();
                    break;
                case 8:
                    Eight();
                    break;
                case 9:
                    Task9();
                    break;
                case 10:
                    Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA!!!!!!!!!!!!!!!!!!!");
                    break;
                default:
                    Console.WriteLine("ERR");
                    break;

            }

            

        }
    }
}