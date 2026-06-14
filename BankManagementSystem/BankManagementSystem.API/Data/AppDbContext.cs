using Microsoft.EntityFrameworkCore;
using BankLoanManagement.API.Models;

namespace BankLoanManagement.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<LoanType> LoanTypes { get; set; }

    public DbSet<LoanApplication> LoanApplications { get; set; }
}
