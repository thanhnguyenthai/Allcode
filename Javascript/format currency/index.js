// toLocaleString() = return a string with a language sensitive representation of this

// number.toLocaleString(locale, {options});

//'localee' = specify that languafe (undefined = default set in brower )
// 'options' = object with formatting options

let num = 100;
//num=num.toLocaleString("en-US"); // us english
//num = num.toLocaleString("hi-IN")// HINDI
//num=num.toLocaleString("de-DE")// standard German


//num=num.toLocaleString("en-US",{style:"currency", currency:"USD"}); // us english

//num=num.toLocaleString("en-US",{style:"currency", currency:"INR"});
//num=num.toLocaleString("en-US",{style:"currency", currency:"EUR"});


//num=num.toLocaleString(undefined,{style:"percent"});
num = num.toLocaleString(undefined,{style:"unit",unit:"celsius"});
console.log(num);


document.getElementById("check").innerHTML = num;