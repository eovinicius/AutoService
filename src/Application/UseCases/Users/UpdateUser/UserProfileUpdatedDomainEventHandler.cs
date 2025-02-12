﻿// namespace Evently.Modules.Users.Application.Users.UpdateUser;

// internal sealed class UserProfileUpdatedDomainEventHandler(IEventBus eventBus)
//     : DomainEventHandler<UserProfileUpdatedDomainEvent>
// {
//     public override async Task Handle(
//         UserProfileUpdatedDomainEvent domainEvent,
//         CancellationToken cancellationToken = default)
//     {
//         await eventBus.PublishAsync(
//             new UserProfileUpdatedIntegrationEvent(
//                 domainEvent.Id,
//                 domainEvent.OccurredOnUtc,
//                 domainEvent.UserId,
//                 domainEvent.FirstName,
//                 domainEvent.LastName),
//             cancellationToken);
//     }
// }
