#frame = a rectangular container to group and hold widgets
from tkinter import *

window = Tk()

frame = Frame(window,bg="pink",bd=5,relief=SUNKEN)
#frame.place(x=0,y=0)
#frame.place(x=100,y=100)
frame.pack(side=BOTTOM) 


button = Button(frame,text="W",font=("Consolas",25),width=3).pack(side=TOP)
button = Button(frame,text="A",font=("Consolas",25),width=3).pack(side=LEFT)
button = Button(frame,text="S",font=("Consolas",25),width=3).pack(side=LEFT)
button = Button(frame,text="D",font=("Consolas",25),width=3).pack(side=LEFT)

window.mainloop()