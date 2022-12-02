// callback = a function passed as an argument
// to another function.


/*
let total = sum(2,3);
displayDom(total);
function sum(x,y){
    let result = x + y;
    return result
}

function displayConsole(output){
    console.log(output);
}

function displayDom(output){
    document.getElementById("mylabel").innerHTML = output;
}
*/


sum(2,3, displayConsole);
function sum(x,y,callback){
    let result = x +y;
    callback(result);
}
sum(2,3, displayDom);
function sum(x,y,callback){
    let result = x +y;
    callback(result);
}


function displayConsole(output){
    console.log(output);
}

function displayDom(output){
    document.getElementById("mylabel").innerHTML = output;
}


