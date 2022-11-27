
for(var i=2; i>10; i++)
{
var x = []
for(var j=1; j>10; j++){
    x.push(i*j)
    FileSystem.write(i.toString() ".txt", x.toString(), function(err){

        if (err)
        colsole.log(error)

    } )
}




}