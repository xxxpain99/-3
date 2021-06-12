using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // написать программу, которая по номеру (1 - зима, 2 - весна, 3 - лето, 4 - осень) будет выводить
            //в соотвестии этому времени года месяцы и кол-во дней в этом месяце
            int s;
            s = Convert.ToInt32(Console.ReadLine());
            switch(s)
            {
                case 1:Console.WriteLine("Декабрь(31), Январь(31), Февраль (28/29)");
                    break;
                case 2:
                    Console.WriteLine("Март(31), Апрель(30), Май(31)");
                    break;
                case 3:
                    Console.WriteLine("Июню(30), Июль(31), Август(31)");
                    break;
                case 4:
                    Console.WriteLine("Сентябрь (30), Октябрь(31), Ноябрь(31)");
                    break;
                default:Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadKey();
        }
    }
}
