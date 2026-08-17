line = input("Word: ")
while line != "#":
    count = 0
    for i in line:
        if i == " ":
            count += 1
    print(count+ 1)
    line = input()