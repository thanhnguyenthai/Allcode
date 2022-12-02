// variable scope = where a variable is accessible

// let = variable are limited to block scope {}
// var = variable are limited to a function(){}

// global variable = is declared outside any function 
// (if global, var will CHANGE browser's window properties)
let name="WINKEY";


doit();

function doit(){
for ( var i = 1; i <= 3; i+=1){
console.log(i);
}
}

//console.log(i);