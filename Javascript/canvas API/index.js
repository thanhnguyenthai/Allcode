// Canvas API = a means for drawing graphics
// Used for animation, games, data visualization

let canvas = document.getElementById("mycanvas");
let context = canvas.getContext("2d");

/*
//Draw lines
context.strokeStyle = "red";
context.lineWidth = 10;
context.beginPath();
context.moveTo(0, 0);
context.lineTo(250,250);
context.lineTo(250,500);
context.moveTo(500, 0);
context.lineTo(250,250);
context.stroke();
*/
/*
// Draw triangle
context.strokeStyle = "grey";
context.fillStyle = "Red";
context.lineWidth = 10;
context.beginPath();
context.moveTo(250,0);
context.lineTo(0,250);
context.lineTo(500,250);
context.lineTo(250,0);

context.stroke();
context.fill();
*/

/*
// draw rectangle

context.fillStyle = "black";
context.fillRect(0,0,250,250);
context.strokeStyle = "black";
context.strokeRect(0,0,250,250);

context.fillStyle = "Red";
context.fillRect(0,250,250,250);
context.strokeStyle = "black";
context.strokeRect(0,250,250,250);

context.fillStyle = "green";
context.fillRect(250,250,250,250);
context.strokeStyle = "black";
context.strokeRect(250,250,250,250);

context.fillStyle = "blue";
context.fillRect(250,0,250,250);
context.strokeStyle = "black";
context.strokeRect(250,0,250,250);

*/

/*
// draw circle
// (x ,y ,z, sAngle, eAngle, counterclockwise)
context.fillStyle = "black";
context.lineWidth = 10;
context.strokeStyle = "clue";
context.beginPath();
context.arc(250,250,200, 0, 2 * Math.PI);
context.stroke();
context.fill();

*/

//Draw text
context.font = "50px MV Boli";
context.fillStyle = "Pink";
context.textAlign = "center";
context.fillText("You WIN", canvas.width / 2, canvas.height / 2);