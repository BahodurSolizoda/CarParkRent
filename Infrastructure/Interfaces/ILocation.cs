using Domain.Models;

namespace Infrastructure.Interfaces;

public interface ILocation
{
    List<Location> GetAllLocations();
    Location GetLocationById(string id);
    bool AddLocation(Location location);
    bool UpdateLocation(Location location);
    bool DeleteLocation(int id);
}