using System;
using System.Drawing;
using System.Text;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1
            //    Чи́сла Фибона́ччи -элементы числовой последовательности в которой первые два числа равны 0 и 1, 
            //    а каждое последующее число равно сумме двух предыдущих чисел, т.е. 0, 1, 1, 2, 3, 5 и т.д.
            //    Создайте массив, содержащий первые 8 чисел данной последовательности
                        
            int[] b = new int[8];

            b[0] = 0;
            b[1] = 1;

            for (int i = 2; i < b.Length; i++)
            {
                b[i] = b[i - 1] + b[i - 2];
            }

            Console.WriteLine("Task 1. Fibonacci Array:");
            foreach (int number in b)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            //Задание 2
            //    Создайте массив типа string, содержащий название 12 месяцев.
            //    Названия должны быть на английском и начинаться с заглавной буквы. 
            //    Также не нужно использовать пробелы и лишние символы, только строка с названием

            string[] months = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.WriteLine("Task 2. Listing the names of the months:");
            foreach (string name in months)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            //Задание 3
            //    Создайте двумерный массив(матрицу) 3x3.
            //    Вам нужно будет создать и проинициализировать двумерный массив типа int.
            //    Элементы массива - матрицы: 
            //    Первая строка -числа 2, 3 и 4 в степени 1 
            //    Вторая строка -числа 2,3 и 4 в степени 2 
            //    Третья - числа 2,3 и 4 в степени 3

            int[,] array1 = new int[3, 3];
           
            for (int i = 0; i< 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array1[i, j] = (int)Math.Pow(j+2, i+1);
                }
            }
            Console.WriteLine("Task 3. Two-dimensional array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array1[(int)i, (int)j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Задание 4
            //    Вам нужно будет создать и проинициализировать jagged array(ломанный массив). 
            //    То есть массив, содержащий массивы разного размера 
            //    Должен содержать следующие элементы(тип double) 
            //    Первый массив -числа от 1 до 5
            //    Второй массив -константы e и pi(используйте класс math) 
            //    Третий массив -логарифм по основанию 10 чисел 1, 10, 100 и 1000(используя функцию log).
            //    Важно! Используйте статический класс Math для констант и логарифмов Ссылка

            double[][] array3 = new double[3][];
            array3[0] = new double[] { 1, 2, 3, 4, 5 };
            array3[1] = new double[] { Math.E, Math.PI };
            array3[2] = new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) };

            Console.WriteLine("Task 4. Jagged array:");
            for (int i = 0; i < array3.Length; i++)
            {
                for (int j = 0; j < array3[i].Length; j++)
                {
                    Console.Write(array3[i][j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            //Задание 5.
            //  Скопируйте первые 3 элемента первого массива во второй.Воспользуйтесь классом Array.
            Console.WriteLine("Task 5. Array: ");

            int[] array = { 1, 2, 3, 4, 5 }; 
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

            Array.Copy(array, 0, array2, 0, 3);

            foreach (int t in array2)
                Console.WriteLine($"{t}");

            Console.WriteLine();

            //Задание 6
            //    Измените размер первого массива так, чтобы в нём стало в два раза больше элементов 
            //    Воспользуйтесь классом Array, метод Resize.ВАЖНО! Массив передаётся через ref. 
            //    Это же ключевое слово вы будете использовать при вызове метода Resize, то есть: 
            //    Array.Resize(ref array, newSize);

            Console.WriteLine("Task 6. Array: ");

            Array.Resize(ref array, 10);

            foreach (int r in array)
                Console.WriteLine($"{r}");

        }
    }
}