// setInterval() = invokes a function repeatedly after a number of milliseconds
// asynchronous function (doesnt pause execution)


let count =0;
let max = window.prompt("Count up to what #?");
max = Number(max);

const myTimer = setInterval(countUp, 100);

function countUp(){
    count +=1;
    console.log(count);
    if (count >= max ){
        clearInterval(myTimer);
    }
}