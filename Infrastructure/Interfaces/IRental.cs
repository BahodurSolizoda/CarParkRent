using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IRental
{
    List<Rental> GetAllRentals();
    Rental GetRentalById(int id);
    bool AddRental(Rental rental);
    bool UpdateRental(Rental rental);
    bool DeleteRental(int id);
}