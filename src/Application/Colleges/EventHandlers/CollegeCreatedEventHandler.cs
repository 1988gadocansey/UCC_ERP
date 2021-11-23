using UCC_ERP.Application.Common.Models;
using UCC_ERP.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace UCC_ERP.Application.Colleges.EventHandlers;

public class CollegeCreatedEventHandler : INotificationHandler<DomainEventNotification<CollegeCreatedEvent>>
{
    private readonly ILogger<CollegeCreatedEventHandler> _logger;

    public CollegeCreatedEventHandler(ILogger<CollegeCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(DomainEventNotification<CollegeCreatedEvent> notification, CancellationToken cancellationToken)
    {
        var domainEvent = notification.DomainEvent;

        _logger.LogInformation("UCC_ERP Domain Event: {DomainEvent}", domainEvent.GetType().Name);

        return Task.CompletedTask;
    }

    
}
