using Tyuiu.BarbashinAV.Sprint3.Task2.V5.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint3.Task2.V5.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidGetSumSeries()  
   {
        Assert.AreEqual(0.333, new DataService().GetSumSeries(0.75, 1, 20));
    } 
} 
