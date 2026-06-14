namespace BankLoanManagement.API.Models;

public class LoanType
{
    public int LoanTypeId {get; set;}
    public string LoanName {get; set;}
    public decimal InterestRate{get; set;}
    public decimal MaxLoanAmount{get; set;}
    public int MaxTenureMonths{get; set;}

    
}