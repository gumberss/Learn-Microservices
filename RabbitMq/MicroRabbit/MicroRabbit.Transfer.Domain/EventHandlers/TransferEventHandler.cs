using MicroRabbit.Banking.Domain.Events;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private IEventBus _bus;

        public TransferEventHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task Handle(TransferCreatedEvent @event)
        {


            return Task.CompletedTask;
        }
    }
}
