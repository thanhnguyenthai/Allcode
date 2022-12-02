class Animal:
    alive = True

    def eat(self):
        print("This animal is eating")
    def sleep(self):
        print("This animal is sleeping")

class Rabbit(Animal):
    def run(self):
        print("This Rabbit is running")
class Fish(Animal):
    def swim(self):
        print("This Fish is swim")
class Dog(Animal):
    def sleep(self):
        print("This Dog is sleeping")

rabbit = Rabbit()
fish = Fish()
dog = Dog()

#print(rabbit.alive)
#fish.eat()
#dog.sleep()

rabbit.run()
fish.swim()
dog.sleep()