#Mark Rogers
#Shadow Maker

from graphics import *

def makeShadow(obj):
    shadow = obj.clone()
    shadow.setFill('grey')
    shadow.setOutline('grey')
    shadow.move(4, 4)
    
    return shadow

def testShadowMaker():
    win = GraphWin()

    c = Circle( Point( 40, 75 ), 30 )
    c.setOutline( 'blue' )
    c.setFill( 'blue' )

    r = Rectangle( Point( 80, 30 ), Point( 140, 140 ))
    r.setFill( 'orange' )
    r.setOutline( 'orange' )
    
    #Shadows for objects
    sc = makeShadow(c)
    sr = makeShadow(r)
    
    #Draw shadows before objects
    sc.draw( win )
    sr.draw ( win )
    c.draw( win )
    r.draw( win )
    
def main():
    testShadowMaker()

main()