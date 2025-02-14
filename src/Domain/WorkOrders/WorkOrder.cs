using Domain.Abstractions;

namespace Domain.WorkOrders;

public class WorkOrder : Entity
{
    public string Number { get; init; }
    public Guid CustomerId { get; private set; }
    public Guid VehicleId { get; private set; }
    public int MileageAtService { get; private set; }
    public WorkOrderStatus WorkOrderStatus { get; private set; }
    public string? CheckList { get; private set; }
    public DateTime IssueDate { get; private set; }

    private WorkOrder() { }
    private WorkOrder(
        string number,
        Guid custumerId,
        Guid vehicleId,
        int mileageAtService,
        WorkOrderStatus workOrderStatus,
        DateTime issueDate,
        string? checkList)
    {
        Number = number;
        CustomerId = custumerId;
        VehicleId = vehicleId;
        MileageAtService = mileageAtService;
        WorkOrderStatus = workOrderStatus;
        IssueDate = issueDate;
        CheckList = checkList;
    }

    public static WorkOrder Create(
        Guid custumerId,
        Guid vehicleId,
        int mileageAtService,
        string? checkList)
    {
        return new WorkOrder(
            Guid.NewGuid().ToString(),
            custumerId,
            vehicleId,
            mileageAtService,
            WorkOrderStatus.Open,
            DateTime.Now,
            checkList);
    }

    public void AttachCheckList(string checkList)
    {
        CheckList = checkList;
    }

    public void RemoveCheckList()
    {
        CheckList = null;
    }

    public void AproveWorkOrder()
    {
        WorkOrderStatus = WorkOrderStatus.Approved;
    }
}