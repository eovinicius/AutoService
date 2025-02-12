using SharedKernel.Erros;

namespace Domain.Vehicle;

public class VehicleErrors
{
    public static Error NotFound(Guid vehicleId) => Error.NotFound(
        "Vehicle.NotFound",
        $"The Vehicle with the Id = '{vehicleId}' was not found");

    public static readonly Error VehicleNotUnique = Error.Conflict(
        "Vehicle.VehicleNotUnique",
        "The provided vehicle is not unique");
}
