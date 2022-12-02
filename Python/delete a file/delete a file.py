#import os, shutil

#path = "D:\\Code\\Python\\delete a file\\test1.txt"

#try:
#    os.remove(path) #delete a file
    #os.rmdir(path) # delete a empty directory
    #shutil.rmtree(path) # delete a directory containing files

#except FileNotFoundError:
#    print (" That file was not found ")
#except PermissionError:
#    print("You do not have permission to delete that")
#except OSError:
#    print ("You cant delete that file")
#else:
#    print (path + " was deleted")