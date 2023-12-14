using FuwearTestApi.Services;

namespace FuwearTestApi.Tests;

[TestClass]
public class UnitTestFibonacciService
{
    [TestMethod]
    public void TestWithZero()
    {
        var service = new FibonacciService();
        var result = service.GetFibonacciNumber(0);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestWithOne()
    {
        var service = new FibonacciService();
        var result = service.GetFibonacciNumber(1);
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void TestWithTwo()
    {
        var service = new FibonacciService();
        var result = service.GetFibonacciNumber(2);
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void TestWithThree()
    {
        var service = new FibonacciService();
        var result = service.GetFibonacciNumber(3);
        Assert.AreEqual(2, result);
    }
}