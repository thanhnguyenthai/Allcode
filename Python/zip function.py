#zip(*iterables) = aggregate elements from two or more iterables (list, tuples, sets, etc.)
# creates a zip object with paired elements stored in tuples for each elements

usernames = ["1","2","3","4","5","6","7","8","9"]
passwords = ["11","22","33","44","55","66","77","88","99"]

users = zip(usernames, passwords)

#print(type(users))

for i in users:
    print(i)