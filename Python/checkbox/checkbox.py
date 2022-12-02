from tkinter import * 
def display():
    if(x.get()==1):
        print("You agree")
    else:
        print("You do not agree")

window = Tk()
x= BooleanVar()
python_photo = PhotoImage(file="D:\Code\Python\checkbox\Dream Dance Logo no background.png")
check_button = Checkbutton(window,
                            text = "I agree to something",
                            variable=x,
                            onvalue=True,
                            offvalue=False,
                            command=display,
                            font=('Arial',20),
                            fg="Green",
                            bg="black",
                            activeforeground="green",
                            activebackground="black",
                            padx=25,
                            pady=10,
                            image=python_photo,
                            compound="left")
check_button.pack()
window.mainloop()