// template literals = delimited with(`)
// instead of double or single quotes
// allows embedded variables and expressi


let name= "Winkey";
let age= 22;
let IQ = 1000;

let text = 
`Hello ${name}<br>
you r ${age}<br>
and have IQ is: ${IQ}`;

document.getElementById("mylabel").innerHTML = text;