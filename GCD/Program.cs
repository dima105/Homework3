using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество входных чисел :");
            
            int numElements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] doubleArray = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                Console.WriteLine("Введите число " + (i + 1) + " :");
                string val = Console.ReadLine();
                int value = Convert.ToInt32(val);
                doubleArray[i] = value;
            }
            int minValue = 0; int NOD = 0;
            bool NOD_found;
            foreach (int item in doubleArray)
            {
                if (minValue > item || minValue == 0)
                {
                    minValue = item;
                }
            }
            while (minValue > 0)
            {
                NOD_found = true;
                //проверяем все элементы массива на общий множитель
                foreach (int elem in doubleArray)
                {
                    //если хотя бы один элемент не делится без остатка, то нет смысла проверять дальше
                    if (elem % minValue != 0)
                    {
                        NOD_found = false;
                        break;
                    }
                }
                if (NOD_found)
                {
                    NOD = minValue;
                    break;
                }
                minValue--;
            }
            Console.WriteLine("Наибольший общий делитель :" + NOD);
        }
    }
}