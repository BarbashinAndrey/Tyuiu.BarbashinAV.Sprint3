using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.BarbashinAV.Sprint3.Task0.V15.Lib;

public class DataService : ISprint3Task0V15
{
    public double GetSumSeries(double value, int startValue, int stopValue)
    {
        double sumSeries = 0;
        for (int i = startValue; i <= stopValue; i++)
            sumSeries += (Math.Pow(value, i) + 2d / (i + 1)) * Math.Sin(value);

        return Math.Round(sumSeries, 3);
    }
} 
