using System;
using MyMethods;


namespace HomeWork_7
{
    class Program
    {
        static void Main(string[] args)
        {
            void FillMatrix (double [,] matrix, int minValue=-10, int maxValue=10)
            {
                Random random = new Random();

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = Math.Round(random.Next(minValue, maxValue)*0.1, 1); // лучше способ чем умножение на 0,1 не придумала. пробовала найти сразу ввод дробных чисел. Если такой способ есть, то с радостью бы попробовала
                    }
                }
            }

            void PrintMatrix (double [,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{(double)matrix[i, j]}\t "); //табуляция
                    }
                    Console.WriteLine();
                }
            }

            void Task47()
            {
                // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
                int rows = MyMethods.MyMethodsClass.Input ("Введите количество строк");
                int columns = MyMethods.MyMethodsClass.Input ("Введите количество столбцов");
                double [,] matrix=new double [rows, columns];
                FillMatrix(matrix);
                PrintMatrix(matrix);

            }

            
            void Task50()
            {
                // Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
                int rows = MyMethods.MyMethodsClass.Input ("Введите количество строк ");
                int columns = MyMethods.MyMethodsClass.Input ("Введите количество столбцов ");
                double [,] matrix=new double [rows, columns];
                FillMatrix(matrix);
                Console.WriteLine( );
                Console.WriteLine("Исчисление количества строк и строчек начинается с 1");
                Console.WriteLine( );
                int rowsIndex = MyMethods.MyMethodsClass.Input ("Введите строку искомого элемента ");
                int columnsIndex = MyMethods.MyMethodsClass.Input ("Введите столбец искомого элемента ");
                Console.WriteLine( );
                if (rowsIndex+1<=rows && columnsIndex+1<=columns)
                {
                    Console.WriteLine($"Значение точки ({rowsIndex}, {columnsIndex}) равно {matrix [rowsIndex-1,columnsIndex-1]}");
                }
                else
                {
                    Console.WriteLine($"Точки с координатами ({rowsIndex}, {columnsIndex}) в массиве не существует");
                }
                Console.WriteLine( );
                PrintMatrix(matrix); // для проверки

            }
            
            void Task52()
            {
                // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
                int rows = MyMethods.MyMethodsClass.Input ("Введите количество строк ");
                int columns = MyMethods.MyMethodsClass.Input ("Введите количество столбцов ");
                double [,] matrix=new double [rows, columns];
                double sum=0;

                FillMatrix(matrix);
                PrintMatrix(matrix);

               for (int j=0; j < matrix.GetLength(1); j++)
                {
                    for (int i=0; i < matrix.GetLength(0); i++)
                    {
                        sum = sum + matrix[i, j];
                    }
                    sum=sum/rows;
                    sum = Math.Round(sum,2);
                    Console.WriteLine($"Среднее значение чисел столбца {j} равно {sum}");
                    sum=0;
                }
            }

            Task52();

        }
    }
}
