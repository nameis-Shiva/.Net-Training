namespace BankLoanManagement.API.DTOs;

public class EmiScheduleDto
{
    public int Month { get; set; }

    public decimal EMI { get; set; }

    public decimal Principal { get; set; }

    public decimal Interest { get; set; }

    public decimal RemainingBalance { get; set; }
}