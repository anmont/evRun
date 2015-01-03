target = 0
if Region(1796,78,43,476).exists("1417940045225.png",.1):
    target = 1
if Region(1796,78,43,476).exists("1417937913860.png",.1):
    target = 1
if target == 0:
    Region(1796,78,43,476).find("1417940045225.png")