def replaceSpace(string):
    allWords = string.split();
    newString = ""

    for i in allWords:
        newString = newString + i + '_'

    newString = newString[:-1]

    return newString

def export():
    fileRead = open("Monsters.cs", 'r')
    fileWrite = open("exportedMonsters.txt", 'w', newline='')
    allLines = fileRead.readlines()
    for line in allLines:
        if "public static enemyvalues" in line:
            fileWrite.write(line[34:-3] + ' ')
        if "mobName" in line:
            fileWrite.write(replaceSpace(line[27:-3]) + ' ')
        if "mobHP" in line:
            fileWrite.write(line[25:-3] + ' ')
        if "mobMaxDMG" in line:
            fileWrite.write(line[29:-3] + ' ')
        if "mobMinDMG" in line:
            fileWrite.write(line[29:-3] + ' ')
        if "mobEXP" in line:
            fileWrite.write(line[26:-3] + '\r\n')

export()
