using Dapper;
using Infrastructure.DataContext;
using Domain.Models;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class CarService(CarParkDbContext con):ICar
{

    public List<Car> GetAllCars()
    {
        using var context = con.Connection();
        string cmd = "select * from Cars";
        var cars = context.Query<Car>(cmd).ToList();
        return cars;
    }

    public Car GetCarById(int id)
    {
        using var context = con.Connection();
        string cmd = "select * from Cars where id=@id";
        var car = context.Query<Car>(cmd, new { id }).FirstOrDefault();
        return car;
    }

    public bool CreateCar(Car car)
    {
        using var context = con.Connection();
        var add = "insert into Cars(model,nanufacturer,year,priceperday) values(@model,@nanufacturer,@year,@priceperday)";
        var added = context.Execute(add, car);
        return added > 0;
    }

    public bool UpdateCar(Car car)
    {
        using var context = con.Connection();
        var toupdate="update Cars set model=@model, manufacturer=@manufacturer, year=@year, priceperday=@priceperday where id=@id";
        var updated = context.Execute(toupdate, car);
        return updated > 0;
    }

    public bool DeleteCar(int id)
    {
        using var context = con.Connection();
        string todelete = "delete from Cars where id=@id";
        var deleted = context.Execute(todelete, new { id });
        return deleted > 0;
    }
}

