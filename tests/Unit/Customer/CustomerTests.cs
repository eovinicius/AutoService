// using Domain.Customers;

// using FluentAssertions;

// using Unit.Abstractions;

// namespace Unit.Customer;

// public class CustomerTests : BaseTest
// {
//     [Fact]
//     public void Create_ShouldReturnCustomer()
//     {
//         // Act
//         var customer = Customer.Create(
//             Faker.Internet.Email(),
//             Faker.Name.FirstName(),
//             Faker.Name.LastName(),
//             Guid.NewGuid().ToString());

//         // Assert
//         customer.Should().NotBeNull();
//     }

//     [Fact]
//     public void Create_ShouldReturnCustomer_WithMemberRole()
//     {
//         // Act
//         var customer = Customer.Create(
//             Faker.Internet.Email(),
//             Faker.Name.FirstName(),
//             Faker.Name.LastName(),
//             Guid.NewGuid().ToString());

//         // Assert
//         customer.Roles.Single().Should().Be(Role.Member);
//     }

//     [Fact]
//     public void Create_ShouldRaiseDomainEvent_WhenCustomerCreated()
//     {
//         // Act
//         var customer = Customer.Create(
//             Faker.Internet.Email(),
//             Faker.Name.FirstName(),
//             Faker.Name.LastName(),
//             Guid.NewGuid().ToString());

//         // Assert
//         CustomerRegisteredDomainEvent domainEvent =
//             AssertDomainEventWasPublished<CustomerRegisteredDomainEvent>(customer);

//         domainEvent.CustomerId.Should().Be(customer.Id);
//     }

//     [Fact]
//     public void Update_ShouldRaiseDomainEvent_WhenCustomerUpdated()
//     {
//         // Arrange
//         var customer = Customer.Create(
//             Faker.Internet.Email(),
//             Faker.Name.FirstName(),
//             Faker.Name.LastName(),
//             Guid.NewGuid().ToString());

//         // Act
//         customer.Update(customer.LastName, customer.FirstName);

//         // Assert
//         CustomerProfileUpdatedDomainEvent domainEvent =
//             AssertDomainEventWasPublished<CustomerProfileUpdatedDomainEvent>(customer);

//         domainEvent.CustomerId.Should().Be(customer.Id);
//         domainEvent.FirstName.Should().Be(customer.FirstName);
//         domainEvent.LastName.Should().Be(customer.LastName);
//     }

//     [Fact]
//     public void Update_ShouldNotRaiseDomainEvent_WhenCustomerNotUpdated()
//     {
//         // Arrange
//         var customer = Customer.Create(
//             Faker.Internet.Email(),
//             Faker.Name.FirstName(),
//             Faker.Name.LastName(),
//             Guid.NewGuid().ToString());

//         customer.ClearDomainEvents();

//         // Act
//         customer.Update(customer.FirstName, customer.LastName);

//         // Assert
//         customer.DomainEvents.Should().BeEmpty();
//     }
// }
