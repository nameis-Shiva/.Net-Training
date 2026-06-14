using BankLoanManagement.API.Models;
using BankLoanManagement.API.DTOs;


public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _repository;

    public CustomerService(ICustomerRepository repository)
    {
        _repository = repository;
    }

    public async Task AddCustomerAsync(CustomerCreateDto dto)
    {
        Customer customer = new Customer
        {
            FullName = dto.FullName,
            Email = dto.Email,
            MobileNumber = dto.MobileNumber,
            AnnualIncome = dto.AnnualIncome
        };

        await _repository.AddAsync(customer);
    }

    public async Task<List<Customer>> GetCustomersAsync()
    {
        return await _repository.GetAllAsync();
    }
}