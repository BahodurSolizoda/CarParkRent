using Domain.Models;

namespace Infrastructure.Interfaces;

public interface ICar
{
    List<Car> GetAllCars();
    Car GetCarById(int id);
    bool CreateCar(Car car);
    bool UpdateCar(Car car);
    bool DeleteCar(int id);
}