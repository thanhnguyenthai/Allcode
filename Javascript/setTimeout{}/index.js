// setTimeout() = invokes a function after a number of milliseconds
 // asynchronous function (doesnt pause execution)


let item = "cryptocurrency";
price = 420.69;

let timer1 = setTimeout(firstMessage, 3000);
let timer2 = setTimeout(secondMessage, 300);
let timer3 = setTimeout(thirdMessage, 300);

function firstMessage(){
    alert(`Buy this ${item} for ${price}!`);
}
function secondMessage(){
    alert(`This is not a scam`);
}
function thirdMessage(){
    alert(`Do it !`);
}


document.getElementById("myButton").onclick=function(){
    clearTimeout(timer1);
    clearTimeout(timer2);
    clearTimeout(timer3);
    alert(`Thx for buying`);
}
