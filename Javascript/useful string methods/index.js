// usefull string properties & methods

let userName = "WINKEY";
let phoneNumber = "123-456-789";

console.log(userName.length);
console.log(userName.charAt(0));
console.log(userName.indexOf("o"));
console.log(userName.lastIndexOf("o"));
///-----
userName = userName.trim();
userName = userName.toUpperCase();
userName = userName.toLowerCase();

console.log(userName);

///------

phoneNumber = phoneNumber.replaceAll("-","");
console.log(phoneNumber);