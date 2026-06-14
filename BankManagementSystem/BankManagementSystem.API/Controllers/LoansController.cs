using Microsoft.AspNetCore.Mvc;
using BankLoanManagement.API.DTOs;

[ApiController]
[Route("api/[controller]")]
public class LoansController : ControllerBase
{
    private readonly ILoanApplicationService _service;

    public LoansController(
        ILoanApplicationService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Apply(
        LoanApplicationCreateDto dto)
    {
        await _service.ApplyLoanAsync(dto);

        return Ok("Loan Application Submitted");
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _service.GetAllAsync());
    }
}