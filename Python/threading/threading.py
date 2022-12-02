# thread = a flow of execution. Like a separate order of instructions.
#       However each thread takes a turn running to achieve concurrency
#       GIL = (global interpreter lock),
#       allows only one thread to hold the control of the Python interpreter at any one time

# cpu bound = program/ task spends most of its time waiting for internal events (CPU interpreter)
# use multiprocessing

# io bound = program/ task spends most of its time waiting for external events ( user input, web scraping)
# use multithreading


import threading 
import time 

def eatbreakfast():
    time.sleep(3)
    print("You eat breakfast")
def drinkcoffee():
    time.sleep(4)
    print("You drank")
def study():
    time.sleep(5)
    print("You r studying")

x = threading.Thread(target=eatbreakfast, args=())
x.start()

y = threading.Thread(target=drinkcoffee, args=())
y.start()

z = threading.Thread(target=study, args=())
z.start()

#eatbreakfast()
#drinkcoffee()
#study()

print(threading.active_count())
print(threading.enumerate())
print(time.perf_counter())

