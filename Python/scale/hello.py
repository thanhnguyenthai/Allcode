from tkinter import * 

def submit():
    print("The temperature is: "+ str(scale.get())+"degree C")

window = Tk()
hotImage = PhotoImage(file='button\like.png')
hotLabel = Label(image=hotImage)
hotLabel.pack()

scale = Scale(window,
                from_=100,
                to=0,
                length=600,
                orient= VERTICAL,  # or HORIZONTAL # orientation is of scale
                font = ('Consolas',20),
                tickinterval=10, #adds numeric indicators for value
                #showvalue=0, #hide current value    
                resolution = 5, #increment of slider 
                troughcolor= 'green',
                fg = 'yellow',
                bg = 'black'
                ) 
scale.set(((scale['from']-scale['to'])/2)+scale['to']) #set current value of slider

scale.pack()

coldImage = PhotoImage(file='button\like.png')
coldLabel = Label(image=coldImage)
coldLabel.pack()
 
button= Button(window,text='submit',
                    command=submit)
button.pack()

window.mainloop()


#vì hình to quá nên k thấy đc submit