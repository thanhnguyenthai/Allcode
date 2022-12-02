class Car {
    constructor(model, year, color){
        this.model = model;
        this.year = year;
        this.color = color;
    }
}

const car1 = new Car("1", 2023, "red");
const car2 = new Car("2", 2024, "green");
const car3 = new Car("3", 2025, "black");

changeColor(car3,"GOLD")
displayInfo(car3);


function displayInfo(car){
console.log(car.model);
console.log(car.year);
console.log(car.color);

}

function changeColor(car, color){
    car.color = color;
}