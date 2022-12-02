//get = binds an objects property to a function
// when that property is accessed

/*
class Car{
    constructor(power){
        this._gas = 10;
        this._power = power;
    }
    get power(){
        return `${this._power}hp`;
    }
    get gas(){
        return `${this._gas}L (${this._gas / 50*100}%)`;
    }
}

let car = new Car(400);

//car._power = 10000000000;

console.log(car.power);

console.log(car.gas);

*/

// set = binds an object property to a function 
// when that property is assigned a value


class Car{
    constructor(power){
        this._gas = 10;
        this._power = power;
    }
    get power(){
        return `${this._power}hp`;
    }
    get gas(){
        return `${this._gas}L (${this._gas / 50*100}%)`;
    }
    set gas(value){
        if (value > 50 ){
            value = 50;
        }
        else if (value < 0 ){

        value = 0;
        }
        
        this._gas = value;
    }
}

let car = new Car(400);

//car.gas = -10000000;
console.log(car.power);

console.log(car.gas);