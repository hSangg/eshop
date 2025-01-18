using MediatR;

namespace Shared.DDD;

public interface IDomainEvent : INotification
{
    Guid EventId { get; set; }
    public DateTime OccurredOn { get; set; }
    public string EventType => GetType().AssemblyQualifiedName!;
}

