# ifname == '_main_'

# y tho?
# 1. Module can  be run as a standalone program 
# 2. Module can be imported and used by other modules 

# Python interpreter sets "Special variables", one of which is _name_
# thenPython will execute the code found within _main_

#if name == 'main':
#    pass
#----------------------------------------------------------------
# Python will assign the name variables a value of 'main' if its the initial module being run

#----------------------------------------------------------------
#Vì không có hàm main() trong Python, khi lệnh chạy chương trình python được đưa cho trình thông dịch, mã ở mức thụt lề cấp 0 sẽ được thực thi. Tuy nhiên, trước khi làm điều đó, nó sẽ xác định một vài biến đặc biệt. __name__ là một trong những biến đặc biệt như vậy. Nếu tệp nguồn được thực thi dưới dạng chương trình chính, trình thông dịch đặt biến __name__ có giá trị “__main__”. Nếu tệp này đang được import từ một mô-đun khác, __name__ sẽ được đặt thành tên của mô-đun.

#__name__ là một biến được tích hợp sẵn để đánh giá tên của mô-đun hiện tại. Vì vậy, nó có thể được sử dụng để kiểm tra xem tập lệnh hiện tại đang được chạy riêng hay được import vào một nơi khác bằng cách kết hợp nó với câu lệnh if, như được hiển thị bên dưới.

#------ 
from unicodedata import name
#import moduletwo
#print(name)
#print(moduletwo.name)


#if name == 'main':
#    print("running this module directly")
#else:
#    print("running other modules indirectly")




def main():
    print("Hello")
if name == 'main':
    main()
         