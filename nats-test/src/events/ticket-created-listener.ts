import { Listener } from './base-listener'
import { Message } from 'node-nats-streaming'
import { TicketCreatedEvent, TicketCreatedEventData } from './ticket-created-event'
import { Subjects } from './subjects'

export class TicketCreatedListener extends Listener<TicketCreatedEvent> {
  readonly subject = Subjects.TicketCreated
  
  queueGroupName: string = 'paymenrs-service'
  
  onMessage(data: TicketCreatedEventData, msg: Message): void {
		console.log('Event data ', data)
    
		msg.ack()
	}
}
