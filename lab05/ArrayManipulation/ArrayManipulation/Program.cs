using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Длина массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] myArray = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("myArray[{0}] = ", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n-* Ваш массив *-");
            foreach (int x in myArray) Console.Write("{0} ", x);

            Console.WriteLine("\n\n... Обработка данных ...");

            Console.WriteLine("Сумма элементов: {0}", ArraySum(myArray));
            Console.WriteLine("Среднее значение: {0:F2}", ArrayMean(myArray));
            ArraySumSigned(myArray, out int sum_pos, out int sum_neg);
            Console.WriteLine("Сумма положительных элементов: {0}", sum_pos);
            Console.WriteLine("Сумма отрицательных элементов: {0}", sum_neg);
            ArraySumEvenOdd(myArray, out int sum_even, out int sum_odd);
            Console.WriteLine("Сумма чётных элементов: {0}", sum_even);
            Console.WriteLine("Сумма нечётных элементов: {0}", sum_odd);

            // Дополнительное задание
            ArrayMinMax(myArray, out int min_elem, out int max_elem, out int min_elem_n, out int max_elem_n);
            Console.WriteLine("Максимальный элемент: {0}, позиция: {1}", max_elem, max_elem_n);
            Console.WriteLine("Минимальный элемент: {0}, позиция: {1}", min_elem, min_elem_n);
            Console.WriteLine("Произведение элементов между макс. и мин. значениями: {0}", ArrayMultInbetween(myArray, min_elem, max_elem));
        }

        private static int ArrayMultInbetween(int[] myArray, int min_elem, int max_elem)
        {
            int res = 1;
            foreach (int elem in myArray)
            {
                if (elem != min_elem && elem != max_elem) res *= elem;
            }

            return res;
        }

        private static int ArraySum(int[] myArray)
        {
            int sum = 0;
            foreach (int x in myArray) sum += x;
            return sum;
        }

        private static void ArraySumSigned(int[] myArray, out int sum_pos, out int sum_neg)
        {
            sum_pos = 0;
            sum_neg = 0;

            foreach (int x in myArray) 
            {
                if (x > 0) sum_pos += x;
                if (x < 0) sum_neg += x;
            }
        }

        private static void ArraySumEvenOdd(int[] myArray, out int sum_even, out int sum_odd)
        {
            sum_even = 0;
            sum_odd = 0;

            foreach (int x in myArray)
            {
                if (x % 2 == 0) sum_even += x;
                if (x % 2 != 0) sum_odd += x;
            }
        }

        private static void ArrayMinMax(int[] myArray, out int min_elem, out int max_elem, out int min_elem_n, out int max_elem_n)
        {
            min_elem = Int32.MaxValue;
            max_elem = Int32.MinValue;
            min_elem_n = -1;
            max_elem_n = -1;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max_elem)
                {
                    max_elem = myArray[i];
                    max_elem_n = i;
                }
                if (myArray[i] < min_elem)
                {
                    min_elem = myArray[i];
                    min_elem_n = i;
                }
            }
        }

        private static float ArrayMean(int[] myArray)
        {
            float sum = 0;
            foreach (int x in myArray) sum += x;
            return sum / myArray.GetLength(0);
        }
    }
}
