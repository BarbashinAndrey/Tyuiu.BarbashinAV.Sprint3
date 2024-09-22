using Tyuiu.BarbashinAV.Sprint3.Task0.V15.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint3.Task0.V15; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #3 | Выполнил: Барбашин А.В. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #0                                                           *"); 
        Console.WriteLine("* Вариант #15                                                          *"); 
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда  *");
        Console.WriteLine("* по формуле, при t = 0,7                                              *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Переменная t = 0,7                                                   *");
        Console.WriteLine("* Старт шага = 1                                                       *");
        Console.WriteLine("* Конец шага = 10                                                      *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");

        var t = 0.7;
        var start = 1;
        var stop = 10;
        Console.WriteLine($"Сумма ряда = {new DataService().GetSumSeries(t, start, stop)}"); 
    } 
} 
