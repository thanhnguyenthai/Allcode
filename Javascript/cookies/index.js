// cookies = a small text file on your computer used to remember information about the user saved in name=value pairs
/*
//document.cookie = "firstname=SpongeBob; expires=Sun, 28/7/2022; path=/";
//document.cookie = "lastname=SquarePants; expires=Sun, 28/7/2022; path=/";
//console.log(document.cookie);
*/
/*
deletecookie("firstname");
deletecookie("lastname");
deletecookie("email");
*/

/*
setcookie("email","WinKey@gmail.com",365);
console.log(document.cookie);
*/


/*
setcookie("firstname","WINKEY",365);
setcookie("lastname","WINKEYT20",365);
console.log(getcookie("firstname"));
console.log(getcookie("lastname"));
*/


const firstText = document.querySelector("#firstText");
const lastText = document.querySelector("#lastText");
const submitBtn = document.querySelector("#submitBtn");
const cookieBtn = document.querySelector("#cookieBtn");


submitBtn.addEventListener("click", () => {
    setCookie("firstName", firstText.value, 365);
    setCookie("lastName", lastText.value, 365);
});

cookieBtn.addEventListener("click", () => {
    firstText.value = getCookie("firstName");
    lastText.value = getCookie("lastName");
});



function setCookie(name, value, daysToLive){
    const date = new Date();
    date.setTime(date.getTime()+ daysToLive * 24 * 60 *60 *1000 );
    let expires = "expires=" + date.toUTCString();
    document.cookie = `${name}=${value}; ${expires}; path=/`;

}

function deleteCookie(name){
    setCookie(name, null,null)
}

/*
function getCookie(name){
    const cDecoded = decodeURIComponent(document.cookie);
    console.log(cDecoded);
}
*/

function getCookie(name){
    const cDecoded = decodeURIComponent(document.cookie);
    const cArray= cDecoded.split("; ");
    let result = null; 

    cArray.forEach(element => {
        if ( element.indexOf(name) == 0 ){
            result = element.substring(name.length + 1)
        }
    })

    return result;
}