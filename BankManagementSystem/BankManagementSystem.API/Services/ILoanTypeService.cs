using BankLoanManagement.API.DTOs;
using BankLoanManagement.API.Models;

public interface ILoanTypeService
{
    Task AddLoanTypeAsync(LoanTypeCreateDto dto);

    Task<List<LoanType>> GetLoanTypesAsync();
}