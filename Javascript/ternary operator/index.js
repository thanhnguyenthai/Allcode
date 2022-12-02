// ternary operator = shortcut for an if/else statement take 3 operands

// 1. a condition with?
// 2. expression if True : 
// 3. expression if False
// condition ? exprIfTrue ; exprIfFalse





let adult = checkage(22);
console.log(adult);

/*
function checkage(age){
  if (age >= 18){
    return true;
  }
  else{
    return false;
  }
}
*/
// =>
function checkage(age){
  return age >= 18 ? true : false;
}

checkwinner(true);
function checkwinner(win){
  win? console.log("you win!") : console.log("you lose!");
}