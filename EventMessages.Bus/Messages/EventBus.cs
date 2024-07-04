using EventMessages.Bus.Abstracts;
using EventMessages.Bus.Contracts;
using MassTransit;

namespace EventMessages.Bus.Messages;

public class EventBus(IPublishEndpoint publishEndpoint) : IEventBus
{
    public async Task Publish<TEvent>(
        TEvent evento,
        CancellationToken cancellationToken) 
        where TEvent : BaseEvent
    {
        await publishEndpoint.Publish(evento, cancellationToken);
    }
}