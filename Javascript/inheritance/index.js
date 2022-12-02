// inheritance = a child class can inherit all the methods and properties from another class

class Animal{
    alive = true;
    eat(){
            console.log(`This ${this.name} is eating ${this.name}`);
        }
        sleep(){
            console.log(`This ${this.name} is sleeping ${this.name}`);
        }
}

class Rabbit extends Animal{
    
    name = "rabbit";   
    jump(){
        console.log(`This ${this.name} is jumping ${this.name}`);
    }
}

class Fish extends Animal{
    name = "fish";
    swim(){
        console.log(`This ${this.name} is swimming ${this.name}`);
    }
}

const rabbit = new Rabbit();
const fish = new Fish();

console.log(rabbit.alive);
rabbit.eat();
rabbit.jump();
rabbit.sleep();
