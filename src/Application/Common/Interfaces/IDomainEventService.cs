using UCC_ERP.Domain.Common;

namespace UCC_ERP.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
