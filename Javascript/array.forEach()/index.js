// array.forEach()= exrcutes a provided callback function once for each array element


let student = ["van","chi","Tuyet"];
student.forEach(capitalize);
student.forEach(print);
function capitalize(element,index,array) {
    array[index]= element[0].toUpperCase()+element.substring(1);
}

console.log(student[0]);


function print(element){
    console.log(element);
}