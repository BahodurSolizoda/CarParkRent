using Domain.Models;
using Infrastructure.Interfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;


namespace WebApp.Controllers;
[ApiController]
[Route("[controller]")]

public class LocationControlle(LocationService locationService):ControllerBase
{
    [HttpGet]
    public List<Location> GetAll()
    {
        var response = locationService.GetAllLocations();
        return response;
    }
    
    [HttpPost]
    public bool AddCarLocation(Location location)
    {
        var response = locationService.AddLocation(location);
        return response;
    }
    
    
    [HttpPut]
    public bool UpdateLocation(Location location)
    {
        var response = locationService.UpdateLocation(location);
        return response;
    }
    
    
    [HttpDelete]
    public bool DeleteLocation(int id)
    {
        var response = locationService.DeleteLocation(id);
        return response;
    }
    
}