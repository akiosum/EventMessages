using EventMessages.Bus.Abstracts;

namespace EventMessages.Bus.Contracts;

public interface IEventBus
{
    Task Publish<TEvent>(TEvent evento, CancellationToken cancellationToken)
        where TEvent : BaseEvent;
}