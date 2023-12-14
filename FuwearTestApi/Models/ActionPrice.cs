namespace FuwearTestApi.Models;

public class ActionPrice
{
    public required string[] Actions { get; set; }
    public required double[][] Prices { get; set; }
}