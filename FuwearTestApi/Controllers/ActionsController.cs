using Microsoft.AspNetCore.Mvc;
using FuwearTestApi.Utils;
using FuwearTestApi.Abstractions;

namespace FuwearTestApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ActionsController : ControllerBase
{
    private readonly IActionsService _actionsService;

    public ActionsController(IActionsService actionsService)
    {
        _actionsService = actionsService;
    }

    [HttpGet]
    public ActionResult<ActionPriceInfo> Get()
    {
        string filePath = "../Data/ActionPrice.json";
        string jsonData = System.IO.File.ReadAllText(filePath);
        var actionsPrices = ActionPriceSerializer.Deserialize(jsonData);

        var prices = actionsPrices.Prices;
        var actions = actionsPrices.Actions;

        var actionWithHighestAvgPrice = _actionsService.GetActionWithHighestAvgPrice(actions, prices);
        return Ok(actionWithHighestAvgPrice);
    }
}