using FuwearTestApi.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FuwearTestApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FibonacciController : ControllerBase
{
    private readonly IFibonacciService _fibonacciService;

    public FibonacciController(IFibonacciService fibonacciService)
    {
        _fibonacciService = fibonacciService;
    }

    [HttpGet("{n}")]
    public ActionResult<int> Get(int n)
    {
        var result = _fibonacciService.GetFibonacciNumber(n);
        return Ok(result);
    }
}
