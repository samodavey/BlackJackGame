
//var http = require('http');

//var PORT = 80;

//var fs = require('fs');

//var path = require('path');

//var server = http.createServer(function (request, response) {

    
//    if (request.url === "/") {

//        fs.readFile('index.html', function (err, html) {
//            response.writeHead(200, { 'Content-Type': 'text/html' });
//            response.write(html);
//            response.end();
//        });      

//    }
//    //else if (request.url.match("\.css$")) {
//    //    var cssPath = path.join(__dirname, ".", request.url);
//    //    var fileStream = fs.createReadStream(cssPath, "UTF-8");
//    //    response.writeHead(200, { 'Content-Type': 'text/css' });
//    //    fileStream.pipe(response);
//    //}
//    //else if (request.url.match("\.js$")) {
//    //    var jsPath = path.join(__dirname, ".", request.url);
//    //    var fileStream2 = fs.createReadStream(jsPath, "UTF-8");
//    //    response.writeHead(200, { 'Content-Type': 'text/javascript' });
//    //    fileStream2.pipe(response);
//    //}
//    //else if (request.url.match("\.mp4$")) {
//    //    var vidPath = path.join(__dirname, ".", request.url);
//    //    var fileStream3 = fs.createReadStream(vidPath, "UTF-8");
//    //    response.writeHead(200, { 'Content-Type': 'video/mp4' });
//    //    fileStream3.pipe(response);
//    //}
//    //else if (request.url.match("\.png$")) {
//    //    var picPath = path.join(__dirname, ".", request.url);
//    //    var fileStream4 = fs.createReadStream(picPath, "UTF-8");
//    //    response.writeHead(200, { 'Content-Type': 'image/png' });
//    //    fileStream4.pipe(response);
//    //}
//    else {
//        response.writeHead(404, { 'Content-Type': 'text/html' });
//        response.end("No page found");
//    }

//})

//server.listen(PORT, function () {
//    console.log('Server listening on port ' + PORT);

//    // var query = window.location.search.substring(1);
//    // var vars = query.split("&");
//    // for (var i = 0; i < vars.length; i++){
//    // var pair = vars[i].split("=");
//    // if(pair[0] == variable){return pair[1];}
//    // }
//    // return (false);
//});


//function sendFileContent(response, fileName, contentType) {
//    fs.readFile(fileName, function (err, data) {
//        if (err) {
//            response.writeHead(404);
//            response.write("Not Found!");
//        }
//        else {
//            response.writeHead(200, { 'Content-Type': contentType });
//            response.write(data);
//        }
//        response.end();
//    });
//}


//server.listen(80);






//var express = require('express');
//    //htmlDir = './html/'
//var app = express();

////Log all requests
//app.use(express.logger());

////Set content directories
//app.use(express.static(__dirname + '/html'));
//app.use('/js', express.static(__dirname + '/js'));
//app.use('/css', express.static(__dirname + '/css'));
//app.use("/image", express.static(__dirname + '/image'));

//app.get('/', function (request, response) {
//    response.sendfile(htmlDir + 'index.html');
//});

////var port = process.env.PORT || 80;
//app.listen(80, function () {
//    console.log("Listening on port 80");
//});









var express = require('express');
var path = require('path');

var app = express();
var PORT = 3000;

app.use(express.static(path.join(__dirname, 'public')));

//public

//app.get('/', function (req, res) {
//    res.send('Hello World!');
//});

//app.get('/count', function (req, res) {
//    res.send(count.toString());

//});

//app.get('/click', function (req, res) {
//    count++;
//    res.send(count.toString());
//});

app.listen(PORT, function () {
    console.log('Example app listening on port ' + PORT);
});