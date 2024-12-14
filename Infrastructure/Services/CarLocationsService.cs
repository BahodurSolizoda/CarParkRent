using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class CarLocationsService( CarParkDbContext con):ICarLocation
{
    public List<CarLocation> GetAllCarLocations()
    {
        using var context = con.Connection();
        string cmd = "select * from CarLocations";
        var cars = context.Query<CarLocation>(cmd).ToList();
        return cars;
    }

    public List<CarLocation> GetCarLocationsByCarId(int carId)
    {
        using var context = con.Connection();
        string cmd = "select * from CarLocations where id=@id";
        var car = context.Query<CarLocation>(cmd, new { carId}).ToList();
        return car;
    }

    public bool AddCarLocation(CarLocation carLocation)
    {
        using var context = con.Connection();
        var toadd="insert into CarLocations (carid) values (@carid)";
        var gotten = context.Query<CarLocation>(toadd).ToList();
        return gotten.Count > 0;
    }

    public bool UpdateCarLocation(CarLocation carLocation)
    {
        using var context = con.Connection();
        var toupdate="update CarLocations set LocationId=@LocationId where LocationId=@LocationId";
        var updated = context.Execute(toupdate, carLocation);
        return updated > 0;
    }

    public bool DeleteCarLocation(int id)
    {
        using var context = con.Connection();
        string todelete = "delete from CarLocations where id=@id";
        var deleted = context.Execute(todelete, new { id });
        return deleted > 0;
    }
}