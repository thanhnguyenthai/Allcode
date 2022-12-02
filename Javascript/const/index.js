// const = a variable that cant be changed

const pi = 3.14159;
let radius;
let circumference;

radius = window.prompt("Enter the radius of a circle: ");
radius = Number(radius);

circumference = 2 * pi * radius;
console.log("The circumferece is: ", circumference);