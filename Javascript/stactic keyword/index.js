// static = belong to the class, not the objects
// properties: useful for caches, fixed- configuration
// methods: usefull for utility functions



class car{
    static numberofcars = 0;

    constructor(model){
        this.model = model;
        car.numberofcars += 1   ;
    }

    static startRace(){
        console.log("3....2....1...Go!")
    }
}

const car1 = new car("1");
const car2 = new car("2");
const car3 = new car("3");
/*
console.log(car1.numberofcars);
console.log(car2.numberofcars);
console.log(car3.numberofcars);
*/

// console.log(car.numberofcars);

car.startRace();