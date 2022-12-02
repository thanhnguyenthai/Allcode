from tkinter import *

# button = you click it, then it does stuff
count = 0
def click():
    global count
    count+=1
    print (count)
    #print("you clicked the button")
window = Tk()

photo = PhotoImage(file='button\like.png')
button = Button(window,
                text="click me",
                command=click,
                font=("comic sans",30),
                fg="blue",
                bg="black",
                activeforeground="Red",
                activebackground="Black",
                state=ACTIVE, # or DISABLED
                image=photo,
                compound='top')

button.pack()

window.mainloop()