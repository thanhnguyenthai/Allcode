// The Date object is used to work with date & times


let date = new Date();
//let date = new Date(100000000000000);
//let date = new Date(2023,0,1,2,3,4,5); // (year, month,  date , hour , min, second, millisecond)

//let date = new Date("January 1 , 2023 00:00:00");
/*
let year = date.getFullYear();
let dayOfMonth = date.getDate();
let dayOfWeek = date.getDay();
let month = date.getMonth();
let hour = date.getHours();
let min = date.getMinutes();
let seconds = date.getSeconds();
let ms = date.getMilliseconds();
*/
/*
date.setFullYear(2024);
date.setMonth(11);
date.setDate(31);
date.setHours(23);
date.setMinutes(1);
date.setSeconds(30);
date.setMilliseconds(0);
*/
//date = date.toLocaleString();



document.getElementById("myLabel").innerHTML = formatTime(date);

function formatDate(date){
    let year = date.getFullYear();
    let month = date.getMonth();
    let dat = date.getDate();
    return `${month}/${day}/${year}`
}

function formatTime(date){
    let hour = date.getHours();
    let minutes = date.getMinutes();
    let seconds = date.getSeconds();
    let amOrpm = hour >= 12? "pm" : "am";

    hour = (hour % 12) || 12;
    
    return `${hour}:${minutes}:${seconds} ${amOrpm}`
}