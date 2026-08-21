line = input("Input: ")
while line != "#":
    a = 0
    e = 0
    i = 0
    o = 0
    u = 0
    for j in line:
        if j == "i" or j =="I":
            i += 1
        elif j == "a" or j == "A":
            a += 1
        elif j == "e" or j == "E":
            e += 1
        elif j == "o" or j == "O":
            o += 1
        elif j == "u" or j == "U":
            u += 1
    print(f"a:{a}, e:{e}, i:{i}, o:{o}, u:{u}")
    line = input()