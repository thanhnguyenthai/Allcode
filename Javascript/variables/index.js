// A variable is a container for storing data in a variable
// A variable behaves as if it was the value that it contains

// Two steps: 
// 1. Declaration (var, let, const)
// 2. Assignment (= assignment operator)

let name = "Bro";
let age = 21;
let student = true;

console.log("Your are", age, "Years old");
console.log("Enrolled: ", student);
console.log(" Hello ", name);

document.getElementById("p1").innerHTML = "Hello " + name;
document.getElementById("p2").innerHTML = "You are " + age + " years old";
document.getElementById("p3").innerHTML = "Enrolled: " + student;