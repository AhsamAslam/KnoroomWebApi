using Knorooms.WebApi.Shared.Events;

namespace Knorooms.WebApi.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}