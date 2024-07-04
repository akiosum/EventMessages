namespace EventMessages.Bus.Events;

public record TicketEvent(
    Guid Id,
    string Title,
    string Description);