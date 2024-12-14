using Domain.Models;
using Infrastructure.Interfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;


namespace WebApp.Controllers;
[ApiController]
[Route("[controller]")]

public class CustomerControlle(CustomerService customerService):ControllerBase
{
    [HttpGet]
    public List<Customer> GetAll()
    {
        var response = customerService.GetAllCustomers();
        return response;
    }
    
    [HttpPost]
    public bool AddCustoner(Customer customer)
    {
        var response = customerService.AddCustomer(customer);
        return response;
    }
    
    
    [HttpPut]
    public bool UpdateCustomer(Customer customer)
    {
        var response = customerService.UpdateCustomer(customer);
        return response;
    }
    
    
    [HttpDelete]
    public bool DeleteCustomer(int id)
    {
        var response = customerService.DeleteCustomer(id);
        return response;
    }
    
}