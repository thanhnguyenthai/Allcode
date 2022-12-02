// nested functions = Functions inside other functions
// Outer functions have access to inner functions
// Inner functions are "hidden" from outside the outer functions
// used in closures (future video topic)



let username = " Bro ";
let userinbox = 0;

login(); 

function login(){
    displayusername();
    displayuserinbox();

    function displayusername(){
        console.log(`HELLO ${username}`);
    }

    function displayuserinbox(){
        console.log(`You have ${userinbox} new messages`);
    }
}