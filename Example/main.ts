import * as protobuf from './protobuf.min.js';

const builder = protobuf.loadProtoFile('element.js');
console.log(builder);

export const socket = new WebSocket('ws://localhost:5000/ws');
socket.onmessage = (message) => console.log(message);
