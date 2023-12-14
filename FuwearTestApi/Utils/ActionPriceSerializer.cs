using System.Text.Json;
using System.Text.Json.Serialization;
using FuwearTestApi.Models;

namespace FuwearTestApi.Utils
{
    public class ActionPriceSerializer
    {
        public static ActionPriceData Deserialize(string jsonData)
        {
            var actionsPrices = JsonSerializer.Deserialize<ActionPriceData>(jsonData);

            var actions = actionsPrices?.Actions;
            var prices = actionsPrices?.Prices;

            return new ActionPriceData
            {
                Actions = actions ?? [],
                Prices = prices ?? []
            };
        }
    }
}
