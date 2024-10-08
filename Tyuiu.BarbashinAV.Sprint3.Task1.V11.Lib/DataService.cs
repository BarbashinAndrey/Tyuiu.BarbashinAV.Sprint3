using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.BarbashinAV.Sprint3.Task1.V11.Lib;

public class DataService : ISprint3Task1V11
{
    public double GetMultiplySeries(double value, int startValue, int stopValue)
    {
        double mulSeries = 1;
        int i = startValue;
        double s = 0.5;
        while (i <= stopValue)
        {
            mulSeries *= Math.Pow(value, i) + s;
            i++;
        }

        return Math.Round(mulSeries, 3);
    }
} 
