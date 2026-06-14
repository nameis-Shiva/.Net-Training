namespace BankLoanManagement.API.DTOs;

public class LoanApplicationCreateDto
{
    public int CustomerId { get; set; }

    public int LoanTypeId { get; set; }

    public decimal RequestedAmount { get; set; }

    public int TenureMonths { get; set; }

    public string Purpose { get; set; } = string.Empty;
}