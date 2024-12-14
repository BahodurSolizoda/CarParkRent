using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class CustomerService(CarParkDbContext con):ICustomer
{
    public List<Customer> GetAllCustomers()
    {
        using var context = con.Connection();
        string toget = "select * from Customers";
        var gotten = context.Query<Customer>(toget).ToList();
        return gotten;
    }

    public Customer GetCustomerById(int customerId)
    {
        using var context = con.Connection();
        string toget = "select * from Customers where CustomerId=@CustomerId";
        var gotten = context.Query<Customer>(toget, new { customerId }).FirstOrDefault();
        return gotten;
    }

    public bool AddCustomer(Customer customer)
    {
        using var context = con.Connection();
        var toadd="insert into Customers (CustomerId) values (@CustomerId)";
        var gotten = context.Query<Customer>(toadd).ToList();
        return gotten.Count > 0;
    }

    public bool UpdateCustomer(Customer customer)
    {
        using var context = con.Connection();
        var toupdate="update Customers set CustomerId=@CustomerId where CustomerId=@CustomerId";
        var updated = context.Execute(toupdate, customer);
        return updated > 0;
    }

    public bool DeleteCustomer(int customerId)
    {
        using var context = con.Connection();
        string todelete = "delete from Customers where id=@id";
        var deleted = context.Execute(todelete, new { customerId });
        return deleted > 0;
    }
}