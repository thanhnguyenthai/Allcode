// slice() extracts a section of a string and return it as a new string, without modifying the original string

let fullName = "WINKEY Thai";
let firstname;
let lastname;
//firstname = fullName.slice(0,3);
//lastname = fullName.slice(3);

firstname = fullName.slice(0, fullName.indexOf(" "));
lastname = fullName.slice(fullName.indexOf(" ")+1);
console.log(firstname);
console.log(lastname);