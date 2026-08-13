#

line = int(input("Number: "))
count = 0
num = 0
while line != 999:
    num += line
    count += 1
    line = int(input("Number: "))


print(f"Sum: {num}\nAverage: {num/count:.2f}")