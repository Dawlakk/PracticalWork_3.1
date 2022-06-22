using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            #region

            Console.Write($"Ведите любое целое число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"Введённое Вами число является чётным.");
            }
            else
            {
                Console.WriteLine($"Введённое Вами число является нечётным.");
            }

            Console.ReadLine();
            #endregion


            //Задание 2
            #region

            //Console.Write($"Здравствуйте! Укажите количество карт, которое у Вас на руках: ");
            //int CartsNumber = int.Parse(Console.ReadLine());

            //int TotalSum = 0;

            //for (int i = 1; i <= CartsNumber; i++)
            //{
            //    Console.Write($"\nУкажите номинал {i}-й карты: ");
            //    string Value = Console.ReadLine();
            //    switch (Value)
            //    {
            //        case "2":
            //        case "3":
            //        case "4":
            //        case "5":
            //        case "6":
            //        case "7":
            //        case "8":
            //        case "9":
            //        case "10":
            //            TotalSum += int.Parse(Value);
            //            break;
            //        case "J":
            //        case "Q":
            //        case "K":
            //        case "T":
            //            TotalSum += 10;
            //            break;
            //        default:
            //            Console.WriteLine($"\nНекорректное значение, попробуйте ещё раз.");
            //            i--;
            //            break;
            //    }
            //}

            //Console.WriteLine($"Значение суммы ваших карт равно {TotalSum}");

            //Console.ReadLine();
            #endregion


            //Задание 3
            #region

            //Console.Write($"Введите любое целое число: ");
            //int N = int.Parse(Console.ReadLine());
            //bool fN = false;
            //int i = 2;
            //while (i < N)
            //{
            //    if (N % i == 0)
            //    {
            //        fN = true;
            //        break;
            //    }
            //    i++;
            //}
            //if (fN == true)
            //{
            //    Console.WriteLine($"Число {N} не является простым.");
            //}
            //else
            //{
            //    Console.WriteLine($"Число {N} является простым.");
            //}
            //Console.ReadLine();
            #endregion
        }
    }
}
