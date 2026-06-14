using BankLoanManagement.API.DTOs;
using BankLoanManagement.API.Models;

public class LoanApplicationService : ILoanApplicationService
{
    private readonly ILoanApplicationRepository _loanRepository;
    private readonly ICustomerRepository _customerRepository;
    private readonly ILoanTypeRepository _loanTypeRepository;

    public LoanApplicationService(
        ILoanApplicationRepository loanRepository,
        ICustomerRepository customerRepository,
        ILoanTypeRepository loanTypeRepository)
    {
        _loanRepository = loanRepository;
        _customerRepository = customerRepository;
        _loanTypeRepository = loanTypeRepository;
    }

    public async Task ApplyLoanAsync(LoanApplicationCreateDto dto)
    {
        Customer? customer =
            await _customerRepository.GetByIdAsync(dto.CustomerId);

        if (customer == null)
        {
            throw new Exception("Customer not found");
        }

        LoanType? loanType =
            await _loanTypeRepository.GetByIdAsync(dto.LoanTypeId);

        if (loanType == null)
        {
            throw new Exception("Loan type not found");
        }

        if (customer.AnnualIncome < 300000)
        {
            throw new Exception(
                "Customer income is below eligibility criteria");
        }

        if (dto.RequestedAmount <= 0)
        {
            throw new Exception(
                "Loan amount must be greater than zero");
        }

        if (dto.RequestedAmount > loanType.MaxLoanAmount)
        {
            throw new Exception(
                "Requested amount exceeds maximum loan amount");
        }

        if (dto.TenureMonths <= 0)
        {
            throw new Exception(
                "Tenure must be greater than zero");
        }

        if (dto.TenureMonths > loanType.MaxTenureMonths)
        {
            throw new Exception(
                "Requested tenure exceeds allowed tenure");
        }

        LoanApplication application = new LoanApplication
        {
            CustomerId = dto.CustomerId,
            LoanTypeId = dto.LoanTypeId,
            RequestedAmount = dto.RequestedAmount,
            TenureMonths = dto.TenureMonths,
            Purpose = dto.Purpose,
            Status = "Pending"
        };

        await _loanRepository.AddAsync(application);
    }

    public async Task<List<LoanApplication>> GetAllAsync()
    {
        return await _loanRepository.GetAllAsync();
    }
}