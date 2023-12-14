using System.Text.Json;
using System.Text.Json.Serialization;
using FuwearTestApi.Models;

namespace FuwearTestApi.Helpers;

public class ActionPriceSerializer
{
    public static ActionPrice Deserialize(string jsonData)
    {
        var actionsPrices = JsonSerializer.Deserialize<ActionPrice>(jsonData);

        var actions = actionsPrices?.Actions;
        var prices = actionsPrices?.Prices;

        return new ActionPrice
        {
            Actions = actions ?? [],
            Prices = prices ?? []
        };
    }
}

