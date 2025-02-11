using SharedKernel;

namespace Domain.WorkOrders;

public class WorkOrder : Entity
{
    public string Number { get; private set; }
    public Guid CustomerId { get; private set; }
    public Guid VehicleId { get; private set; }
    public int MileageAtService { get; private set; }
    public WorkOrderStatus Status { get; private set; }

    private WorkOrder() { }

    public WorkOrder Create(Guid custumerId, Guid vehicleId, int mileageAtService)
    {
        return new WorkOrder()
        {
            Id = new Guid(),
            CustomerId = CustomerId,
            VehicleId = vehicleId,
            MileageAtService = mileageAtService,
            Status = WorkOrderStatus.InProcress
        };
    }
}
