# filter() = creates a collection of elements from an iterable for which a function returns true
# filter(function, iterable).
#Hàm filter() trong Python lọc ra các phần tử theo điều kiện của hàm func từ list, dict... Hàm này sẽ chỉ trả về những giá trị mà điều kiện trong func chấp nhận (có nghĩa là True).

friends = [("1", 21), ("2", 12), ("3", 33)]

age = lambda data:data[1]>=18

drinkingbuddies = list(filter(age, friends))

for i in drinkingbuddies:
    print(i)
