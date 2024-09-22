using Tyuiu.BarbashinAV.Sprint3.Task1.V11.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint3.Task1.V11; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        Console.Title = "Спринт #3 | Выполнил: Барбашин А.В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #3                                                            *");
        Console.WriteLine("* Тема: Оператор цикла while                                           *");
        Console.WriteLine("* Задание #1                                                           *");
        Console.WriteLine("* Вариант #11                                                          *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                                                           *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу используя цикл while, которая вычисляет           *");
        Console.WriteLine("* произведение ряда по формуле, при a=0,75                                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Переменная a = 0,75                                                  *");
        Console.WriteLine("* Старт шага = 1                                                       *");
        Console.WriteLine("* Конец шага = 14                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        var a = 0.75;
        var start = 1;
        var stop = 14;
        Console.WriteLine($"Произведение ряда = {new DataService().GetMultiplySeries(a, start, stop)}");
    } 
} 
