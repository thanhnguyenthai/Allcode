// arrow function expression = compact alternative to a traditional function
// => 
          /*
const greeting = (username, age) => console.log(`Hello ${username}`);
greeting("WINKEY");
*//*
const percent = (x , y) => x/y*100;
console.log(`${percent(10 , 50)}%`);

*/


let grade = [ 100, 50, , 90, 60 ];

grade.sort((x,y) => y - x);
grade.forEach((element) => console.log(element));



