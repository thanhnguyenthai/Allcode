// object = A group of properties and methods 
// properties = what an object has
// methods = what an object can do
// use . to access properties/methods 


const car = {
    // properties
    model:"Mustang",
    color:"red",
    year:"2009",
// method
    drive : function(){
        console.log("you drive the car");
    },
    brake : function(){
        console.log("you step on the brakes");
    }
}

//use . to access properties/methods

console.log(car.model);
console.log(car.color);
console.log(car.year);

car.drive();
car.brake();

// can be use car2, car3,... just do same thing


