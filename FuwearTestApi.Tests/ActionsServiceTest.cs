using FuwearTestApi.Services;
using FuwearTestApi.Helpers;

namespace FuwearTestApi.Tests;

[TestClass]
public class UnitTestActionsService
{
    [TestMethod]
    public void TestWithOneAction()
    {
        var service = new ActionsService();
        var result = service.GetActionWithHighestAvgPrice(new[] { "A", "B", "C" }, new[] { new[] { 1.0, 2.0, 3.0 } });
        Assert.AreEqual("C", result.Name);
        Assert.AreEqual(3, result.AvgPrice);
    }

    [TestMethod]
    public void TestWithTwoActions()
    {
        var service = new ActionsService();
        var result = service.GetActionWithHighestAvgPrice(new[] { "A", "B", "C" }, new[] { new[] { 1.0, 2.0, 3.0 }, new[] { 4.0, 5.0, 6.0 } });
        Assert.AreEqual("C", result.Name);
        Assert.AreEqual(4.5, result.AvgPrice);
    }

    [TestMethod]
    public void TestWithJsonFile()
    {
        string filePath = "./Data/ActionPrice.json";
        string jsonData =  File.ReadAllText(filePath);
        var actionsPrices = ActionPriceSerializer.Deserialize(jsonData);

        var prices = actionsPrices.Prices;
        var actions = actionsPrices.Actions;
        var service = new ActionsService();
        var actionWithHighestAvgPrice = service.GetActionWithHighestAvgPrice(actions, prices);

        Assert.AreEqual("GOOG", actionWithHighestAvgPrice.Name);
        Assert.AreEqual(11.660000000000002, actionWithHighestAvgPrice.AvgPrice);
    }
}