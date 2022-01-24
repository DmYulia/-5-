using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        begin:
            int q = 0;
        enter:
            Console.WriteLine($"Выберите номер задачи (1 или 2) или нажмите 3 для выхода..");
            q = Convert.ToInt32(Console.ReadLine());
            switch (q)
            {
                case 1:
                    goto first;
                case 2:
                    goto second;
                case 3:
                    goto end;
                default:
                    Console.WriteLine("_Ошибка ввода данных! Попробуйте еще раз..");
                    goto enter;
            }
        first:
            double[] mas7 = new double[7];
            Console.WriteLine($"_Введите 7 числовых значений массива..");
            for( int i=0; i<7; i++)
            {
                mas7[i] = Convert.ToDouble(Console.ReadLine());
            }
            double sum = 0;
            for( int i=0; i<7; i++)
            {
                sum += mas7[i];
            }
            Console.WriteLine($"_Среднее арифметическое элементов массива: {sum/7}");
            goto begin;
        second:
            double n = 0;
            q = 0;
            do
            {
                Console.WriteLine($"Введите целочисленную размерность массива N..");
                n = Convert.ToDouble(Console.ReadLine());
                if ((n % 1) != 0)
                    Console.WriteLine("_Ошибка ввода данных! Попробуйте еще раз..");
                else q++;
            }
            while (q == 0);
            int N = (int)n;
            int[,] masn = new int[N,N];
            for ( int i=0; i<N; i++)
            {
                for ( int j=0; j<N; j++)
                {
                    if (((i - j) % 2) == 0)
                    {
                        masn[i, j] = 1;
                        Console.Write($"{masn[i,j]} ");
                    }
                    else
                    {
                        masn[i, j] = 0;
                        Console.Write($"{masn[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
            goto begin;
        end:
            Console.WriteLine($"GoodBuy!!");
            Console.ReadKey();
        }
    }
}
