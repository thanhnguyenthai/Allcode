# Prevents a user from creating an object of that class 
# + compels a user to override abstract methods in a child class 

# abstract class = a class which contains one or more abstract methobs.
# abstract methods = a method that has a declaration but does not have an implementation.

from abc import ABC, abstractmethod

class Vehicle(ABC):
    @abstractmethod
    def go(self):
        pass

    @abstractmethod
    def stop(self):
        pass
    
   
class Car(Vehicle):
    def go(self):
        print("You drive the car")
    def stop(self):
        print ("Car stopped")
class Motorcycle(Vehicle):
    def go(self):
        print("You drive the motorcycle")
    def stop(self):
        print ("Motorcycle stopped")

#vehicle = Vehicle()
car = Car()
motorcycle = Motorcycle()

#vehicle.go()
car.go()
motorcycle.go()

car.stop()
motorcycle.stop()