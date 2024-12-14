using Domain.Models;

namespace Infrastructure.Interfaces;

public interface ICarLocation
{
    List<CarLocation> GetAllCarLocations();
    List<CarLocation> GetCarLocationsByCarId(int carId);
    bool AddCarLocation(CarLocation carLocation);
    bool UpdateCarLocation(CarLocation carLocation);
    bool DeleteCarLocation(int id);
}