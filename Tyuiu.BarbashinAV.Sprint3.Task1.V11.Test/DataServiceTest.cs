using Tyuiu.BarbashinAV.Sprint3.Task1.V11.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint3.Task1.V11.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidGetMultiplySeries()  
   {
        Assert.AreEqual(0, new DataService().GetMultiplySeries(0.75, 1, 14));
    } 
} 
