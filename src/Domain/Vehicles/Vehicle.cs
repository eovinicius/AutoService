using Domain.WorkOrders;

using SharedKernel;

namespace Domain.Vehicles;

public class Vehicle : Entity
{
    public Guid CustumerId { get; private set; }
    public string NumberPlate { get; private set; }
    public string Brand { get; private set; }
    public string Model { get; private set; }
    public string Year { get; private set; }
    public string Color { get; private set; }
    public int Mileage { get; private set; }

    private Vehicle() { }

    public static Vehicle Create(Guid custumerId, string numberPlate, string brand, string model, string year, string color, int mileage)
    {
        return new Vehicle
        {
            Id = new Guid(),
            NumberPlate = numberPlate,
            CustumerId = custumerId,
            Brand = brand,
            Model = model,
            Year = year,
            Color = color,
            Mileage = mileage,
            CreatedAt = DateTime.Now
        };
    }

}
