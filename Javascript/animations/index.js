
/*
const mybutton = document.getElementById("mybutton");
const myanimation = document.getElementById("mydiv");

mybutton.addEventListener("click",begin);

function begin(){
    let timerId = null;
    let x = 0;
    let y = 0;

    timerId = setInterval(frame,5);

    function frame(){
if (x>= 200 || y >= 200){
    clearInterval(timerId);
}
else{
    x+=1;
    y+=1;
    myanimation.style.left = x +"px";
    myanimation.style.top = y +"px";
}
    }
}
*/

/*
const mybutton = document.getElementById("mybutton");
const myanimation = document.getElementById("mydiv");

mybutton.addEventListener("click",begin);

function begin(){
    let timerId = null;
    let degrees = 0;

    timerId = setInterval(frame,5);

    function frame(){
if (degrees >= 360 ){
    clearInterval(timerId);
}
else{
  degrees += 1;
  myanimation.style.transform = "rotateX("+ degrees+ "deg)"; 
 // myanimation.style.transform = "rotateY("+ degrees+ "deg)"; 
 // myanimation.style.transform = "rotateZ("+ degrees+ "deg)"; 
}
    }
}

*/


/*
const mybutton = document.getElementById("mybutton");
const myanimation = document.getElementById("mydiv");

mybutton.addEventListener("click",begin);

function begin(){
    let timerId = null;
    let degrees = 0;
    let x = 0;
    let y = 0;

    timerId = setInterval(frame,5);

    function frame(){
if (x>= 200 || y >= 200){
    clearInterval(timerId);
}
else{
  degrees += 10; // Speed
  x +=1 ;
  y +=1 ; 
   myanimation.style.left = x +"px";
    myanimation.style.top = y +"px";
  myanimation.style.transform = "rotateX("+ degrees+ "deg)"; 
 // myanimation.style.transform = "rotateY("+ degrees+ "deg)"; 
 // myanimation.style.transform = "rotateZ("+ degrees+ "deg)"; 
}
    }
}

*/


const mybutton = document.getElementById("mybutton");
const myanimation = document.getElementById("mydiv");

mybutton.addEventListener("click",begin);

function begin(){
    let timerId = null;
    let scaleX = 1;
    let scaleY = 1;

    timerId = setInterval(frame,5);

    function frame(){
if (scaleX >= 2){
    clearInterval(timerId);
}
else{
  scaleX += 0.01;
  myanimation.style.transform = "scale("+scaleX+","+scaleY+")";
}
    }
}