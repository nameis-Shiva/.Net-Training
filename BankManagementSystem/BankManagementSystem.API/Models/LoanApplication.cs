using System.ComponentModel.DataAnnotations;

namespace BankLoanManagement.API.Models;

public class LoanApplication
{
   
    public int ApplicationId {get; set;}
    public int CustomerId {get; set;}
    public int LoanTypeId{get; set;}
    public decimal RequestedAmount{get; set;}
    public int TenureMonths{get; set;}
    public string Purpose{get; set;}
    public string Status{get; set;}
    public Customer Customer { get; set; } = null!;
    public LoanType LoanType { get; set; } = null!;

    
}