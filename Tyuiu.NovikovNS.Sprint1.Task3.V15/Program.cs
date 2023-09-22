using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NovikovNS.Sprint1.Task3.V15.Lib;

namespace Tyuiu.NovikovNS.Sprint1.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Новиков Н. С. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Новиков Никита Сергеевич | ИСТНб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double v1, v2, S, T;
            Console.WriteLine("Введите значение скорости первого автомобиля V1: ");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение скорости второго автомобиля V2: ");
            v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение времени T: ");
            T = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение первоначального расстояния между автомобилями S: ");
            S = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Через " + T + " часов автомобили будут находиться на расстоянии " + ds.DistanceOverTime(v1,v2,S,T) + " км");
            Console.ReadKey();
        }
    }
}
