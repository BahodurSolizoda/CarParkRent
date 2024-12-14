using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
using Infrastructure.Interfaces;

public class RentalService(CarParkDbContext con):IRental
{
    public List<Rental> GetAllRentals()
    {
        using var context = con.Connection();
        string toget = "select * from Rentals";
        var gotten = context.Query<Rental>(toget).ToList();
        return gotten;
    }

    public Rental GetRentalById(int id)
    {
        using var context = con.Connection();
        string toget = "select * from Rentals where RentalId=@RentalId";
        var gotten = context.Query<Rental>(toget, new { id }).FirstOrDefault();
        return gotten;
    }

    public bool AddRental(Rental rental)
    {
        using var context = con.Connection();
        var add = "insert into Rentals(CarId,CustomerId,StartDate,EndDate, TotalCost) values(@CarId,@CustomerId,@StartDate,@EndDate,@TotalCost)";
        var added = context.Execute(add, rental);
        return added > 0;
    }

    public bool UpdateRental(Rental rental)
    {
        using var context = con.Connection();
        var toupdate="update Rentals set RentalId=@RentalId where RentalId=@RentalId";
        var updated = context.Execute(toupdate, rental);
        return updated > 0;
    }

    public bool DeleteRental(int id)
    {
        using var context = con.Connection();
        string todelete = "delete from Rentals where RentalId=@id";
        var deleted = context.Execute(todelete, new { id });
        return deleted > 0;
    }
}