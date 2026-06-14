using Microsoft.EntityFrameworkCore;
using BankLoanManagement.API.Data;
using BankLoanManagement.API.Models;

public class LoanApplicationRepository : ILoanApplicationRepository
{
    private readonly AppDbContext _context;

    public LoanApplicationRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(LoanApplication application)
    {
        await _context.LoanApplications.AddAsync(application);
        await _context.SaveChangesAsync();
    }

    public async Task<List<LoanApplication>> GetAllAsync()
    {
        return await _context.LoanApplications.ToListAsync();
    }

    // ✅ NEW: Get loan by Id (needed for approve/reject)
    public async Task<LoanApplication?> GetByIdAsync(int id)
    {
        return await _context.LoanApplications.FindAsync(id);
    }

    // ✅ NEW: Update loan status (approve/reject)
    public async Task UpdateAsync(LoanApplication application)
    {
        _context.LoanApplications.Update(application);
        await _context.SaveChangesAsync();
    }
}