using Microsoft.EntityFrameworkCore;
using BankLoanManagement.API.Data;
using BankLoanManagement.API.Models;

public class LoanTypeRepository : ILoanTypeRepository
{
    private readonly AppDbContext _context;

    public LoanTypeRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<LoanType>> GetAllAsync()
    {
        return await _context.LoanTypes.ToListAsync();
    }

    public async Task<LoanType?> GetByIdAsync(int id)
    {
        return await _context.LoanTypes.FindAsync(id);
    }

    public async Task AddAsync(LoanType loanType)
    {
        await _context.LoanTypes.AddAsync(loanType);
        await _context.SaveChangesAsync();
    }
}