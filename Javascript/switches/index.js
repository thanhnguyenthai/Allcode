// switch = statement that examines a value for a match against many cas clauses.
//More efficient that many "else if " statements

/*
let grade = "A" ;

if (grade == "A"){
  console.log("You did great");
} 
else if (grade == "B"){
  console.log("You did good");
} 
else if (grade == "C"){
  console.log("You did ok");
} 
else if (grade == "D"){
  console.log("You passed");
} 
else if (grade == "F"){
  console.log("You False");
} 
else{
  console.log(grade, "You so bad, Failed");
}
*/

/*
let grade = "A";
switch (grade) {
  case "A":
    console.log("You did great");
    break;
  case "B":
    console.log("You did good");
    break;
  case "C":
    console.log("You did ok");
    break;
  case "D":
    console.log("You passed");
    break;
   case "F":
    console.log("You failed");
    break;
  default:
    console.log(grade,"is not a letter of grade");
}
*/

let grade = 59;
switch (true) {
  case grade >= 90 :
    console.log("You did great");
    break;
  case grade >= 80 :
    console.log("You did good");
    break;
  case grade >= 70 :
    console.log("You did ok");
    break;
  case grade >= 60 :
    console.log("You passed");
    break;
  case grade < 60 :
    console.log("You failed");
    break;
  default:
    console.log(grade,"is not a letter of grade");
}