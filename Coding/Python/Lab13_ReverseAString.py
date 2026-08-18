line = input("Line: ")
while line != "#":
    reversedString = ""
    for i in line:
        reversedString = i + reversedString
    print(reversedString)
    line = input("Line: ")
