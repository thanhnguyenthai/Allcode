// spread operator = allows an iterable such as an array or string to be expanded
// in places where zerp or more arguments are expected (unpacks the elements)
/*

let name="WINKEY";
let num=[1,2,3,4,5,6,7,8,9];
console.log(...name);console.log(...num);


let maximum = Math.max(...num);
console.log(maximum);
*/


let class1 = ["1","2","3"];
let class2 = ["4","5","6"];

class1.push(...class2);
console.log(...class1);