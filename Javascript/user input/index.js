// How to accept user input

// Easy way with a window prompt

// let username = window.prompt("What is your name? : ");
//console.log(username);

// DIFFICULT way html textbox
let username;

document.getElementById("myButton").onclick = function(){
    username = document.getElementById("textBox").value;
    console.log(username);
    document.getElementById("myLabel").innerHTML = "Hello " + username;
}