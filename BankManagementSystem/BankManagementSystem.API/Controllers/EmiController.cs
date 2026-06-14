using Microsoft.AspNetCore.Mvc;
using BankLoanManagement.API.DTOs;

[ApiController]
[Route("api/[controller]")]
public class EmiController : ControllerBase
{
    private readonly IEmiService _emiService;

    public EmiController(IEmiService emiService)
    {
        _emiService = emiService;
    }

    [HttpGet("schedule")]
    public IActionResult GetSchedule(decimal principal, decimal rate, int months)
    {
        var result = _emiService.GenerateSchedule(principal, rate, months);
        return Ok(result);
    }
}