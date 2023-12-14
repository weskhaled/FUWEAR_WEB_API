namespace FuwearTestApi.Abstractions;

public interface IActionsService
{
    ActionPriceInfo GetActionWithHighestAvgPrice(string[] actions, IEnumerable<IEnumerable<double>> prices);
}
