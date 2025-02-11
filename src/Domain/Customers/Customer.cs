using Domain.Vehicles;

using SharedKernel;

namespace Domain.Customers;

public class Customer : Entity
{
    public string Name { get; private set; }
    public string Document { get; private set; }

    private Customer() { }

    public static Customer Create(string name, string document)
    {
        return new Customer()
        {
            Id = new Guid(),
            Name = name,
            Document = document,
        };
    }
}
