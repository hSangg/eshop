
namespace Catalog.Products.Events;

public record ProductCreatedEvent(Product Product)
    : IDomainEvent
{
    Guid IDomainEvent.EventId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    DateTime IDomainEvent.OccurredOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

