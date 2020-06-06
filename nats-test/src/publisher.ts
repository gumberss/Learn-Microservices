import nats from 'node-nats-streaming'

console.clear()

const stan = nats.connect('ticketing', 'abc', {
	url: 'http://localhost:4222',
})

stan.on('connect', () => {
	console.log('Publisher conected to NATS')

	const data = JSON.stringify({
		id: '321',
		title: 'connected',
		price: 20,
  })
  stan.publish('ticket:created', data, () => {
    console.log('Event published')
  })
})
