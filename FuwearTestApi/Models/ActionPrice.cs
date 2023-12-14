namespace FuwearTestApi.Models;

public class ActionPriceData
{
    public required string[] Actions { get; set; }
    public required double[][] Prices { get; set; }
}