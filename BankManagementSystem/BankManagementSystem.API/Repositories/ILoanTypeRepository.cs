using BankLoanManagement.API.Models;

public interface ILoanTypeRepository
{
    Task<List<LoanType>> GetAllAsync();

    Task<LoanType?> GetByIdAsync(int id);

    Task AddAsync(LoanType loanType);
}