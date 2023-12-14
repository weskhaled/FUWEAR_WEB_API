
using FuwearTestApi.Abstractions;

namespace FuwearTestApi.Services;
public class ActionsService : IActionsService
{
    public ActionPriceInfo GetActionWithHighestAvgPrice(string[] actions, IEnumerable<IEnumerable<double>> prices)
    {
        var priceArray = prices.Select(p => p.ToArray()).ToArray();
        var actionWithHighestAvgPrice = actions.Select((action, index) =>
        {
            double sum = 0;
            for (int i = 0; i < priceArray.GetLength(0); i++)
            {
                sum += priceArray[i][index];
            }
            double avg = sum / priceArray.GetLength(0);
            return new ActionPriceInfo { Name = action, AvgPrice = avg };
        })
        .OrderByDescending(a => a.AvgPrice)
        .First();

        return actionWithHighestAvgPrice;
    }
}
