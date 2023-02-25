file = open('file.txt', 'r', encoding='utf-8')

resultData = list()

for line in file.readlines():
    resultData.append(tuple(line.split('\n')[0].split(';')))

file.close()

print(resultData)