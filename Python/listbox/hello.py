#listbox = A listing of selectable text items within its own container

def submit():
    food = []
    for index in listbox.curselection():
        food.insert(index,listbox.get(index))
    print("You have order: ")

    for index in food:
        print(index)
def add():
    listbox.insert(listbox.size(),entryBox.get())
    listbox.config(height=listbox.size())

def delete():
    for index in reversed(listbox.curselection()):
        listbox.delete(index)
    listbox.config(height=listbox.size())

from tkinter import *

window = Tk()

listbox = Listbox(window,
                    bg='green',
                    font=("Constantia",35),
                    width=12,
                    selectmode=MULTIPLE)
listbox.pack()

listbox.insert(1,"111")
listbox.insert(2,"222")
listbox.insert(3,"333")
listbox.insert(4,"444")

listbox.config(height=listbox.size())

entryBox = Entry(window)
entryBox.pack()


submitButton = Button(window,
                        text="submit",
                        command=submit)

submitButton.pack()

addButton = Button(window,
                    text="add",
                    command=add)
addButton.pack()

deleteButton = Button(window,
                    text="delete",
                    command=delete)
deleteButton.pack()


window.mainloop()