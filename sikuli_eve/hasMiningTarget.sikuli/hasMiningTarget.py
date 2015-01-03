mypass = 0
if Region(1572,93,82,81).exists("1417930852203.png",.1):
    mypass = 1
if Region(1563,76,100,120).exists("1417931783618.png",.1):
    mypass = 1
if Region(1563,76,100,120).exists("1417955670640.png",.1):
    mypass = 1
if Region(1563,76,100,120).exists("1417975201753.png",.1):
    mypass = 1
if Region(1563,76,100,120).exists("1418045239588.png",.1):
    mypass = 1
if mypass == 0:
   Region(1578,102,51,55).find("1417930852203.png")