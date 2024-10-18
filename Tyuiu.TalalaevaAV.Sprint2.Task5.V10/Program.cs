using System.Globalization;
using Tyuiu.TalalaevaAV.Sprint2.Task5.V10.Lib;
namespace Tyuiu.TalalaevaAV.Sprint2.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнила: Талалаева А.В. | ИИПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Талалаева Александра Васильевна | ИИПБ-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу,которая использует оператор switch вычисляет требуемое*");
            Console.WriteLine("* значение и возвращает результат.                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            int g, m, n;
            Console.WriteLine("Введите год:");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res=ds.FindDateOfPreviousDay(g, m, n);
            Console.WriteLine(res);


        }
    }
}
