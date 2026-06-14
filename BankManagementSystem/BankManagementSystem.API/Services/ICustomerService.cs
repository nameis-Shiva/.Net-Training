using BankLoanManagement.API.Models;
using BankLoanManagement.API.DTOs;

public interface ICustomerService
{
    Task AddCustomerAsync(CustomerCreateDto dto);

    Task<List<Customer>> GetCustomersAsync();
}