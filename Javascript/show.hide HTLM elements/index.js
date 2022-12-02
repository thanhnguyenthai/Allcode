const mybutton = document.querySelector("#mybutton");
const myimg = document.querySelector("#myimg");

mybutton.addEventListener("click", () => {
    
    if(myimg.style.visibility == "hidden"){
        myimg.style.visibility = "visible";
    }
    else{
        myimg.style.visibility = "hidden";
    }
})