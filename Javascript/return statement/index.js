// return = returns a value back to the place where you invoked a function



let area;
let width;
let height;

width = window.prompt("Enter width");  // prompt: vé ra bảng thông báo OK or cancel
height = window.prompt("Enter height"); 
area = getarea(width, height);
console.log(area);

function getarea(width, height) {
  return width * height;
  
}