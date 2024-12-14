using Domain.Models;
using Infrastructure.Interfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;


namespace WebApp.Controllers;
[ApiController]
[Route("[controller]")]

public class RentalController(RentalService rentalService):ControllerBase
{
    [HttpGet]
    public List<Rental> GetAll()
    {
        var response = rentalService.GetAllRentals();
        return response;
    }
    
    [HttpPost]
    public bool AddRental(Rental rental)
    {
        var response = rentalService.AddRental(rental);
        return response;
    }
    
    
    [HttpPut]
    public bool UpdateRental(Rental rental)
    {
        var response = rentalService.UpdateRental(rental);
        return response;
    }
    
    
    [HttpDelete]
    public bool DeleteRental(int id)
    {
        var response = rentalService.DeleteRental(id);
        return response;
    }
    
}