#attributes
class Car:
   


# special method: Will construct objects for us
    def __init__(self,make,model,year,color):
        self.make = make
        self.model = model
        self.year = year
        self.color = color

#method
    def drive(self): #self refers to the object that is using this method
        print("This " + self.model+ "is driving")
    def stop(self):
        print("This " + self.model+ "is stopped")
