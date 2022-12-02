class Car {
    constructor(model, year, color){
        this.model = model;
        this.year = year;
        this.color = color;
    }
    drive(){
        console.log(`You drive the ${this.model}`);
    }
}

const car1 = new Car("1", 2023, "red");
const car2 = new Car("2", 2024, "green");
const car3 = new Car("3", 2025, "black");

const cars = [car1, car2, car3];
/*
console.log(cars[0].model); 
console.log(cars[2].model); 
console.log(cars[1].model); 
*/
/* 
cars[0].drive();
cars[2].drive();
cars[1].drive();
*/
startRace(cars);
function startRace(cars){
    for(const car of cars){
        car.drive();
    } 
}