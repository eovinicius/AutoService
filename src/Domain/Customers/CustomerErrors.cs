using Domain.Abstractions.Erros;

namespace Domain.Customers;

public class CustomerErrors
{
    public static Error NotFound(Guid customerId) => Error.NotFound(
        "Customer.NotFound",
        $"The Customer with the Id = '{customerId}' was not found");

    public static Error Unauthorized() => Error.Failure(
        "Customer.Unauthorized",
        "You are not authorized to perform this action.");

    public static readonly Error NotFoundByEmail = Error.NotFound(
        "Customer.NotFoundByEmail",
        "The Customer with the specified email was not found");

    public static readonly Error EmailNotUnique = Error.Conflict(
        "Customer.EmailNotUnique",
        "The provided email is not unique");
}
