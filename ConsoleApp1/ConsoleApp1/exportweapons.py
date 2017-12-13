def replaceSpace(string):
    allWords = string.split();
    newString = ""

    for i in allWords:
        newString = newString + i + '_'

    newString = newString[:-1]

    return newString

def export():
    fileRead = open("Weapons.cs", 'r')
    fileWrite = open("exportedfile.txt", 'w', newline='')
    allLines = fileRead.readlines()
    for line in allLines:
        if "public weaponvalues" in line:
            fileWrite.write(line[28:-3] + ' ')
        if "wepName" in line:
            fileWrite.write(replaceSpace(line[27:-3]) + ' ')
        if "wepDesc" in line:
            fileWrite.write(replaceSpace(line[27:-3]) + ' ')
        if "wepMinDMG" in line:
            fileWrite.write(line[29:-3] + ' ')
        if "wepMaxDMG" in line:
            fileWrite.write(line[29:-3] + ' ')
        if "wepAtkSpd" in line:
            fileWrite.write(line[29:-2] + '\r\n')

export()
