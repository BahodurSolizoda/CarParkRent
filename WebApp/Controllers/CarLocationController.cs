using Domain.Models;
using Infrastructure.Interfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;


namespace WebApp.Controllers;
[ApiController]
[Route("[controller]")]

public class CarLocationController(CarLocationsService carLocationsService):ControllerBase
{
    [HttpGet]
    public List<CarLocation> GetAll()
    {
        var response = carLocationsService.GetAllCarLocations();
        return response;
    }
    
    [HttpPost]
    public bool AddCarLocatiom(CarLocation carLocation)
    {
        var response = carLocationsService.AddCarLocation(carLocation);
        return response;
    }
    
    
    [HttpPut]
    public bool UpdateCarLocation(CarLocation carLocation)
    {
        var response = carLocationsService.UpdateCarLocation(carLocation);
        return response;
    }
    
    
    [HttpDelete]
    public bool DeleteCustomer(int id)
    {
        var response = carLocationsService.DeleteCarLocation(id);
        return response;
    }
    
}