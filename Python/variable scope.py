# scope = the region that a variable is recognized
# A variable is only available from inside the region it is created.
# A global and locally scoped versions of a variable can be created

# Phạm vi của 1 biến là cùng mà 1 biến được công nhận
# 1 biến chỉ là có sẵn từ bên trong khu vực rằng nó được tạo ra
# Python will follow:
# L = Local
# E = Enclosing
# G = Global
# B = Built-in

#name = "Win" # global scope (acailable inside & outside functions)

#def display_name():
#    name = "Key" # local scope (available only inside this function)
#    print(name)

#display_name()
#print(name)