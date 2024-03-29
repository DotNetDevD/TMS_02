﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class RandomOneRankArray
    {
        int[] a;

        public RandomOneRankArray()
        {
            Console.Write("Введите длину одномерного массива: ");
            int length = Program.Input();
            while (length < 1)
            {
                Console.Write("Длина не может быть меньше 1 элемента: ");
                length = Program.Input();
            }
            a = new int[length];
            a.FillRandNum(); // заполняем массив
        }

        public void ShowInfo()
        {
            a.Print(); // выводим
            a.FindMaxElement(); // находим максимальный элемент
            a.FindMinElement(); // находим минимальный элемент
            a.FindSum(); // находим сумму элементов
            a.FindAvg(); // находим среднее арифметическое
        }

        public void BubbleSort()
        {
            Console.WriteLine("Сортировка пузырьком: ");
            a.BubbleSort();
            a.Print();
        }

        public void MergeSort()
        {
            Console.WriteLine("Сортировка слиянием: ");
            a.MergeSort();
            a.Print();
        }

    }
}
