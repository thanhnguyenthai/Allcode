# dictionary comprehension = create dictionaries using an expression
# can reply for loops and certain lambda functions

# dictionary = {key: expression for (key,value) in iterable}
# dictionary = {key: expression for (key,value) in iterable if conditional}
# dictionary = {key: (if/else) for (key,value) in iterable}
# dictionary = {key: function(value) for (key,value) in iterable}
#----------------------------------------------------------------
#citiesinF = {'1': 1, '2':2,'3':3,'4':4,'5':5,'6':6}
#citiesinC = {key: round((value-32)*(5/9)) for (key,value) in citiesinF.items()}
#print(citiesinC)
#----------------------------------------------------------------
#weather = {'1': "11", '2':"22".'3':"33"}
#sunnyweather = {key: value for {key,value} in weather.items() if value == "sunny"}
#print(sunnyweather)
#-----------------------------------
#cities = {'1': 1, '2':2,'3':3,'4':4,'5':5,'6':6}
#desccities = {key: ("Warm" if value >= 40 else "COLD") for (key,value) in cities.items()}
#print(desccities)
#-----------------------------------
def checktemp(value):
    if value >= 70:
        return "HOT"
    elif 69>= value >= 40:
        return "Warm"
    else:
        return "COLD"


cities = {'1': 1, '2':2,'3':3,'4':4,'5':5,'6':6}
desccities = {key: checktemp(value) for (key,value) in cities.items()}
print(desccities)