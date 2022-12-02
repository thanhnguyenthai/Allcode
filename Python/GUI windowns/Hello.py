from tkinter import *

#widgets = GUI elements: buttins, textboxes, labels, images
#windows = serves as a container to hold or contain these widgets

window = Tk()  # instantiate an instance of a window
window.geometry("420x420")
window.title("WinKey")

icon = PhotoImage(file='D:\Code\Python\GUI windowns\Dream Dance Logo no background.png')
window.iconphoto(True,icon)
window.config(background="black") #https://colors-picker.com/hex-color-picker/

window.mainloop() # place window on computer screen, listen for events