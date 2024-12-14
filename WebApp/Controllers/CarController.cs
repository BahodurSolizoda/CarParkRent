using Domain.Models;
using Infrastructure.Interfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;


namespace WebApp.Controllers;
[ApiController]
[Route("[controller]")]

public class CarController(ICar carService):ControllerBase
{
    [HttpGet]
    public List<Car> GetAll()
    {
        var response = carService.GetAllCars();
        return response;
    }
    
    [HttpPost]
    public bool AddCar(Car car)
    {
        var response = carService.CreateCar(car);
        return response;
    }
    
    
    [HttpPut]
    public bool UpdateCar(Car car)
    {
        var response = carService.UpdateCar(car);
        return response;
    }
    
    
    [HttpDelete]
    public bool DeleteCar(int id)
    {
        var response = carService.DeleteCar(id);
        return response;
    }
    
}