const answer = Math.floor(Math.random()*10+1);
let guesses = 0;

document.getElementById("submitButton").onclick = function() {

    let guess = document.getElementById("Guess").value
    guesses+=1;

    if(guess == answer) {
        alert(`${answer} is the #. It tool u ${guesses} guesses`);
    }
    else if (guess < answer){
        alert("Too small");
    }
    else {
        alert("Too large");
    }
}