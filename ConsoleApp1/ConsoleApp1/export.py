def export():
    fileRead = open("Weapons.cs", 'r')
    fileWrite = open("exportedfile.txt", 'w')
    allLines = fileRead.readlines()

    for line in allLines:
        if "public static weaponvalues" in line:
            fileWrite.Read()
    
    

export()
