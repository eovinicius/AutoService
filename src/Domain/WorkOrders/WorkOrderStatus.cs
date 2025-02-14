namespace Domain.WorkOrders;

public enum WorkOrderStatus
{
    Open,
    WaitingForApproval,
    Approved,
    InProgress,
    WaitingForParts,
    Completed,
    WaitingForPickup,
    Canceled,
    WarrantyClaim
}
