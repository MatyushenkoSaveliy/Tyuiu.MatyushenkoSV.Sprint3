using System;
using Tyuiu.MatyushenkoSV.Sprint3.Task3.V16.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint3.Task3.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Матюшенко С. В. | ВШЦТ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Матюшенко Савелий Владимирович | ВШЦТ                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать количество букв 'с' в строке          *");
            Console.WriteLine("* ice nice ice creamcc                                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "ice nice ice creamcc";
            char item = 'c';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ = " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetCharCount(value, item);
            Console.WriteLine("Количество символов = " + res);

            Console.ReadKey();
        }
    }
}