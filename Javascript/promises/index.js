// promises = object that encapsulates the result of an asynchronous operation 
// let asynchronous method return values like synchronous method 
// "I promise to return something in the future"
/*
const promise = new Promise((resolve, reject) => {

let fileLoaded = false; 
if (fileLoaded){
    resolve("fileLoaded");
}
else{
    reject("file NOT Loaded");
}
});


promise.then(value => console.log(value))
    .catch(error => console.log(error));

*/


const wait = time => new Promise( resolve => {
    setTimeout(resolve, time);

});


wait(3000).then(() => console.log("Thank for waiting!"))
