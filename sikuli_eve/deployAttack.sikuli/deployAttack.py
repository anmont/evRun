Region(1816,586,242,260).rightClick(Pattern("1417934387718.png").similar(0.90))
sleep(1)
click(Pattern("1417934047348.png").similar(0.82))
if Region(1808,629,246,224).exists(Pattern("1418276211199.png").exact(),1):
   Region(1811,602,241,255).click(Pattern("1418276211199.png").exact().targetOffset(-10,10)) 