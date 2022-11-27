https://www.mediafire.com/file/sr43g4d20gf6dv5/%25E2%259A%25A1120FPS_FIX_LAG_ML_ANTI_LAG_25_Nov_2022.zip/file

// File System module -> Built-in Module 
var fs = require('fs')



// Creating a file -> fs.writeFile/fs.appendFile

// WriteFile - Nayi file banata hai agar exist nahi krti aur data jo bhi pass krte hai second parameter mein jo add krdeta hai
// Aur agar file pehle se exist krti hai toh uske andar ke content ko replace krdeta hai


/*
fs.writeFile("masood.txt", "Ayush", function(err){
    if(err)
    {
        console.log("Hey, there's an error")
    }
    else
    {
        console.log("File Created")
    }
})

*/
// Agar file exist nahi krti, to wo ek nayi file banake usme data add krdega
// Agar file exist krti hai toh wo kya krega, wo data krdega

/*
fs.appendFile("masood.txt", "Holaa hello ", function(err){
    if(err)
    console.log(err)
    else
    console.log("Appended data")
})
*/

/* Creating 1000 files in one go 
for(let i=0; i<1000; i++)
{
    fs.writeFile(i.toString() + ".txt", i.toString(), function(err)
    {
        if(err)
        console.log(err)
    })

}
*/

/* Delete a file */

/*
fs.unlink("0.txt", function(err){
    if(err)
    {
        console.log(err)
    }
})

*/

/* Deleting 1000 files in one go 
for(let i=1; i<1000; i++)
{
     fs.unlink(i.toString() + ".txt", function(err){
        if(err)
        {
            console.log(err)
        }
     })
}
*/

/* Creating a folder using javascript code 

fs.mkdir("Ayush", function(err){
    if(err)
    console.log(err)
})

*/
/* To delete a folder 
fs.rmdir("Ayush", function(err){
      if(err)
      {
        console.log(err)
      }
 })

 */

 /* Reading a file */

//  fs.readFile("index.js", "UTF8", function(err, data){
//       if(err)
//       {
//         console.log(err)

//       }
//       else 
//       {
//         console.log(data)
//       }
//  })

/* This function helps to read the content of the directory
 fs.readdir("../Project1",function(err, data){
    if(err)
    {
        console.log(err)
    }
    else{
        console.log(data)
    }
 })
 */

 /*
  This is to move the file

 var fs = require('fs')

var oldPath = 'old/path/file.txt'
var newPath = 'new/path/file.txt'

fs.rename(oldPath, newPath, function (err) {
  if (err) throw err
  console.log('Successfully renamed - AKA moved!')
})

*/