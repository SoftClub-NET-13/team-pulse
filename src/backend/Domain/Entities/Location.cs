using Domain.Common;

namespace Domain.Entities;

public class Location : BaseEntity
{
    public Guid CountryId { get; set; }
    public Country? Country { get; set; }
    public Guid CityId { get; set; }
    public City? City { get; set; }
    public Guid AddressId { get; set; }
    public Address? Address { get; set; }
    public Guid StreetId { get; set; }
    public Street? Street { get; set; }
    
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public ICollection<Employee> Employees { get; set; } = [];
}