namespace BankLoanManagement.API.DTOs;

public class CustomerCreateDto
{
    public string FullName { get; set; }

    public string Email { get; set; }

    public string MobileNumber { get; set; }

    public decimal AnnualIncome { get; set; }
}
