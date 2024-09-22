using Tyuiu.BarbashinAV.Sprint3.Task0.V15.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint3.Task0.V15.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidGetSumSeries()  
   {
        Assert.AreEqual(4.063, new DataService().GetSumSeries(0.7, 1, 10));
   } 
} 
