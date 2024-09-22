using Tyuiu.BarbashinAV.Sprint3.Task2.V5.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint3.Task2.V5; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        Console.Title = "Спринт #3 | Выполнил: Барбашин А.В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #3                                                            *");
        Console.WriteLine("* Тема:                                                                *");
        Console.WriteLine("* Задание #2                                                           *");
        Console.WriteLine("* Вариант #5                                                           *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                                                           *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет      *");
        Console.WriteLine("* сумму ряда по формуле, при a = 0,75                                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Переменная a = 0,75                                                  *");
        Console.WriteLine("* Старт шага = 1                                                       *");
        Console.WriteLine("* Конец шага = 20                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        var a = 0.75;
        var start = 1;
        var stop = 20;
        Console.WriteLine($"Сумма ряда = {new DataService().GetSumSeries(a, start, stop)}");
    } 
} 
