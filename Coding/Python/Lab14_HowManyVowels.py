line = input("Input: ")
while line != "#":
    count = 0
    for i in line:
        if i == "*":
            count += 1
    print(count)
    line = input()
