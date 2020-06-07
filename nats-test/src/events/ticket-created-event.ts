import { Subjects } from './subjects'

export interface TicketCreatedEvent {
	subject: Subjects.TicketCreated

	data: TicketCreatedEventData
}

export interface TicketCreatedEventData {
	id: string
	title: string
	price: number
}
