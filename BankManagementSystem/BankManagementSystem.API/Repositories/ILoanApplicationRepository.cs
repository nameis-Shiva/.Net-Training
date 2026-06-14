using BankLoanManagement.API.Models;

public interface ILoanApplicationRepository
{

    Task<LoanApplication?> GetByIdAsync(int id);

    Task UpdateAsync(LoanApplication application);
    Task AddAsync(LoanApplication application);

    Task<List<LoanApplication>> GetAllAsync();
}