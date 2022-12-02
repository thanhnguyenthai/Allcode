// synchronous code = in an ordered sequence.
// step by step linear instructions 
// (start now , finish now)



console.log("Start");
console.log("This is asynchronous");
console.log("Finish");

// asynchronous code = out of sequence.
// Ex:  Access a database 
// Fetch a file
// Tasks that take time 
// ( Start now , finish sometime later)


console.log("Start");
setTimeout(() => console.log("This is asynchronous"), 5000);
console.log("Finish");