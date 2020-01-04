using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEvenetBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<TEvent, THandler>() 
            where TEvent : Event 
            where THandler: IEventHandler<TEvent>;
    }
}
