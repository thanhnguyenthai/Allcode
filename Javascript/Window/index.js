// window = interface used to talk to the web browser the DOM is a property of the window

//console.dir(window);
/*
console.log(window.innerWidth);
console.log(window.innerHeight);

console.log(window.outerWidth);
console.log(window.outerHeight);
*/

//console.log(window.scrollX);
//console.log(window.scrollY);

//console.log(window.location.href);
//window.location.href="https://google.com";
//console.log(window.location.hostname);
//console.log(window.location.pathname);


const mybutton = document.querySelector("#mybutton");
//mybutton.addEventListener("click",() => window.open("https://google.com"));
//mybutton.addEventListener("click",() => window.close());
//mybutton.addEventListener("click",() => window.print());

//window.alert("Hello");
//window.confirm("Press OK ");


let age = window.prompt("Enter your age");
if (age < 18){
    window.alert("You must be 18+");
    window.close();
}