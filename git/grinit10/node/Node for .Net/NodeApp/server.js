var http = require('http');
const express = require('express');
const app = express();
//app.set('view engine', 'pug');
var port = process.env.PORT || 1337;

app.get('/', (req, res) => res.render('pug/index', {title: 'Express + jade'}));
app.post('/api/users', (req,res) => res.send({ 'id': 1, 'name': 'Arnab' }));
http.createServer(app).listen(port);