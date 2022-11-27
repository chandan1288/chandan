// var express = require('express')
// var app = express()

// app.get('/', function(res, req){
//     req.send('hi this is my super generator')
// })


// app.listen(6100, function(){

//     console.log('This is Generator')
// })

var fs = require('fs')

for(var i=2; i<=10; i++)
{
var x = []
for(var j=1; j<=10; j++)
    {
    x.push(i*j)
    }
    fs.writeFile(i.toString() + ".txt", x.toString(), function(err){

        if (err)
        colsole.log(error)

    } )
}


