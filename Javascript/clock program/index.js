const myLabel = document.getElementById('myLabel');



update();
setInterval(update, 1000);


function update(){
    let date = new Date();
    myLabel.innerHTML = formatTime(date);

    function formatTime(date) {
        let hour = date.getHours();
        let minutes = date.getMinutes();
        let seconds = date.getSeconds();
        let amPm = hour >- 12 ? "pm" : "am";
        hour = (hour % 12 ) || 12;

        hour = formatZero(hour);
        minutes = formatZero(minutes);
        seconds = formatZero(seconds);

        return `${hour} : ${minutes} : ${seconds} ${amPm}`;
    }
    function formatZero(time){
        time = time.toString();
        return time.length < 2 ? "0" + time : time;
    }
}
