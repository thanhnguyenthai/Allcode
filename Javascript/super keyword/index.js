// supper = refers to parent class. 
// commonly used to invoke constructor of a parent class


class Animal{
    constructor(name,age){
        this.name = name;
        this.age = age;
    }

}
class Rabbit extends Animal{
    constructor(name, age, runspeed){
        super(name,age);
        this.runspeed = runspeed;
    }
}
class Fisher extends Animal{
    constructor(name, age, swimspeed){
        super(name,age);
        this.swimspeed = swimspeed;
    }
}

const rabbit = new Rabbit("rabbit", 2, 40);
const fisher = new Fisher("fisher", 10, 20);

console.log(rabbit.name);
console.log(rabbit.age);
console.log(rabbit.runspeed);



