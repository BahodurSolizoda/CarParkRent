using Domain.Models;

namespace Infrastructure.Interfaces;

public interface ICustomer
{
    List<Customer> GetAllCustomers();
    Customer GetCustomerById(int customerId);
    bool AddCustomer(Customer customer);
    bool UpdateCustomer(Customer customer);
    bool DeleteCustomer(int customerId);
}