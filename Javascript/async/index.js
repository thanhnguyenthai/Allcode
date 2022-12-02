// async = make a function return a Promise

async function loadFile(){

    let fileLoaded = true; 

if (fileLoaded){
    return "fileLoaded" ;
}
else{
    throw "file NOT Loaded";
}
}

loadFile().then(value => console.log(value))
.catch(error => console.log(error));

