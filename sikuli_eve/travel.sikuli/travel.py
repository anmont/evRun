travel = 0
lastPos = 0
while travel == 0:
    #currentPos = capture(119,113,113,26)
    
    #Region(121,237,13,13).rightClick("1418294697144.png")
    Region(121,237,13,13).rightClick();
    if exists("1418294797627.png"):
        click("1418294797627.png")
    if exists(Pattern("1418295127686.png").similar(0.90)):
        click(Pattern("1418295127686.png").similar(0.92))
        travel = 1
        sleep(1)
    #newPoint = new_reg.capture()
    if travel == 0:
        wait(Pattern("1418473000273.png").similar(0.96),FOREVER)
        sleep(2)
