const app = require('./app');
const http = require("http");
const port = process.env.PORT || 4444;

const server = http.createServer(app);
server.listen(port)