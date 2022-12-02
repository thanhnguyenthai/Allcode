// give us the ability to check more than 1 condition concurrently
// && AND (both conditions must be true )
// || or (Either condition can be true)



let temp = 50;
let sunny = true;
if (temp > 0 && temp < 30 && sunny){
  console.log("Good weather");
}

else{
  console.log("bad weather");
}

if (temp <=0 || temp >= 30){
  console.log("Bad weather");
}
else{
  console.log("Good weather");
}
