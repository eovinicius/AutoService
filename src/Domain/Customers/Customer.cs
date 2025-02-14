using Domain.Abstractions;

namespace Domain.Customers;

public sealed class Customer : Entity
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string DocumentNumber { get; private set; }
    public string Address { get; private set; }

    private Customer() { }

    public Customer(Guid id, string name, string documentNumber, string address)
    {
        Id = id;
        Name = name;
        DocumentNumber = documentNumber;
        Address = address;
    }

    public static Customer Create(string name, string documentNumber, string address)
    {
        return new Customer(Guid.NewGuid(), name, documentNumber, address);
    }
}
