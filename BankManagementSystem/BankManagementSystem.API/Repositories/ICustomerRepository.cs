using BankLoanManagement.API.Models;

public interface ICustomerRepository
{
    Task<List<Customer>> GetAllAsync();

    Task<Customer> GetByIdAsync(int id);

    Task AddAsync(Customer customer);
}
