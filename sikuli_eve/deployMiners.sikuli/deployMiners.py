Region(1797,613,268,167).rightClick(Pattern("1417810579385.png").similar(0.91))
sleep(1)
click("1417934047348.png")
sleep(4)
rightClick("1417810579385.png")
sleep(1)
click("1417934138054.png")
if Region(1808,629,246,224).exists(Pattern("1418276211199.png").exact(),1):
   Region(1811,602,241,255).click(Pattern("1418276211199.png").exact().targetOffset(-10,10)) 