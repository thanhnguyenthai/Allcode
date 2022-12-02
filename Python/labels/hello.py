from tkinter import *

#label = an area widget that holds text and/or an image within a window

window = Tk()
photo = PhotoImage(file='D:\Code\Python\labels\Dream Dance Logo no background.png')
label = Label(window,
              text = "Hello World",
              font=('Arial',40,'bold'),
              fg='green',#fontground
              bg='black',#background
              relief=RAISED, #or use SUNKEN,...
              bd=10,
              padx=20,
              pady=20,
              image=photo,
              compound='top')



label.pack()
#label.place(x= 100, y = 100)
window.mainloop()
