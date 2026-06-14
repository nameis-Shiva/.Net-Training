using BankLoanManagement.API.DTOs;
using BankLoanManagement.API.Models;

public interface ILoanApplicationService
{
    Task ApplyLoanAsync(LoanApplicationCreateDto dto);

    Task<List<LoanApplication>> GetAllAsync();
}