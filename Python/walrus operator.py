#valrus operator :=
# với toán tử này, bạn có thể gán biến trong lệnh thay vì phải viết thêm 1 số dòng.
#new to Python 3.8
#assignment expression aka walrus operator
#assigns values to variables as part of a larger expression
#----------------------------------------------------------------
##happy=True
##print(happy) ->True
# Đổi thành: 
#print(happy := True)


#-----------------------    
# foods = list()
#while True:
#   foods = input("What do you want to: ")
#       if food == "quit":
#           break
#   food.append(food)

# Đổi thành:
foods = list()
while food := input("What do you want to: ") != "quit":
    foods.append(food)


