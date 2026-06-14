using BankLoanManagement.API.DTOs;
using BankLoanManagement.API.Models;

public class LoanTypeService : ILoanTypeService
{
    private readonly ILoanTypeRepository _repository;

    public LoanTypeService(ILoanTypeRepository repository)
    {
        _repository = repository;
    }

    public async Task AddLoanTypeAsync(LoanTypeCreateDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.LoanName))
        {
            throw new Exception("Loan name is required");
        }

        if (dto.InterestRate <= 0)
        {
            throw new Exception("Interest rate must be greater than zero");
        }

        if (dto.MaxLoanAmount <= 0)
        {
            throw new Exception("Max loan amount must be greater than zero");
        }

        if (dto.MaxTenureMonths <= 0)
        {
            throw new Exception("Max tenure must be greater than zero");
        }

        LoanType loanType = new LoanType
        {
            LoanName = dto.LoanName,
            InterestRate = dto.InterestRate,
            MaxLoanAmount = dto.MaxLoanAmount,
            MaxTenureMonths = dto.MaxTenureMonths
        };

        await _repository.AddAsync(loanType);
    }

    public async Task<List<LoanType>> GetLoanTypesAsync()
    {
        return await _repository.GetAllAsync();
    }
}