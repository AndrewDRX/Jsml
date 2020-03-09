"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var protobuf = require("./protobuf.min.js");
var builder = protobuf.loadProtoFile('element.js');
console.log(builder);
exports.socket = new WebSocket('ws://localhost:5000/ws');
exports.socket.onmessage = function (message) { return console.log(message); };
//# sourceMappingURL=main.js.map