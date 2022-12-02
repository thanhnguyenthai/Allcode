# Radio button = similar to checkbox, but you can only select one from a group


from tkinter import *

food = ["1","2","3"]

def order():
    if(x.get()==0):
        print("You order 1")
    elif(x.get()==1):
        print("You order 2")
    elif(x.get()==2):
        print("You order 3")
    else:
        print("???")

window = Tk()

photo1 = PhotoImage(file='button\like.png')
photo2 = PhotoImage(file='button\like.png')
photo3 = PhotoImage(file='button\like.png')
LOLimage = [photo1,photo2,photo3]

x = IntVar()
for index in range(len(food)):
    radiobutton = Radiobutton(window,
                            text=food[index], # adds text to radio button
                            variable=x, # group radiobuttons together if they share the same variable
                            value=index, #assigns each radiobutton a different value
                            padx = 25, #add padding on x-axis
                            font=("Impact", 50),
                            image = LOLimage[index], #adds image to radiobuttons
                            compound = 'left', #adds image & text (left-side)
                            indicatoron=0, # eliminate circle indicators
                            width=375, #set width of radiobuttons
                            command=order #set command of radiobutton to function
                            ) #

    radiobutton.pack(anchor=W)
window.mainloop()