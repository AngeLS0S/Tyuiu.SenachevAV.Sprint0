namespace Tyuiu.SenachevAV.Sprint0.Task2.V0.Test;

using System;
using Tyuiu.SenachevAV.Sprint0.Task2.V0.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckGetMessageValid()
    {
        var name = "Андрей";
        var res = DataService.GetMessage(name);
        Assert.AreEqual("Привет, Андрей", res);
    }

}