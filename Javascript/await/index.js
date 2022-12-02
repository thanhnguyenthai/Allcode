// await = makes an async function wait for a Promise

async function loadFile(){

    let fileLoaded = true; 

    if (fileLoaded){
        return "fileLoaded" ;
    }
    else{
        throw "file NOT Loaded";
    }
}


async function startProcess(){
    try{
    let message = await loadFile();
    console.log(message);
    }
    catch(error){
        console.log(error);
    }
}
startProcess();


//loadFile().then(value => console.log(value))
//.catch(error => console.log(error));

