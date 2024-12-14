using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class LocationService(CarParkDbContext con):ILocation
{
    public List<Location> GetAllLocations()
    {
        using var context = con.Connection();
        string toget = "select * from Locations";
        var gotten = context.Query<Location>(toget).ToList();
        return gotten;
    }

    public Location GetLocationById(string id)
    {
        using var context = con.Connection();
        string toget = "select * from Locations where LocationId=@LocationId";
        var gotten = context.Query<Location>(toget, new { id }).FirstOrDefault();
        return gotten;
    }

    public bool AddLocation(Location location)
    {
        using var context = con.Connection();
        var toadd="insert into Locations (LocationId) values (@LocationId)";
        var gotten = context.Query<Location>(toadd).ToList();
        return gotten.Count > 0;
    }

    public bool UpdateLocation(Location location)
    {
        using var context = con.Connection();
        var toupdate="update Locations set LocationId=@LocationId where LocationId=@LocationId";
        var updated = context.Execute(toupdate, location);
        return updated > 0;
    }

    public bool DeleteLocation(int id)
    {
        using var context = con.Connection();
        string todelete = "delete from Locations where id=@id";
        var deleted = context.Execute(todelete, new { id });
        return deleted > 0;
    }
}