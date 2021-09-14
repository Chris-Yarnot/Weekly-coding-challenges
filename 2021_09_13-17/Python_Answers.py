# Online Python compiler (interpreter) to run Python online.
# Write Python 3 code in this online editor and run it.
import math;
tubeDiameter= 4;
foilThickness= 0.0025;
#series of perfect circles
#this model gives the numbers you're looking for
def foil_circles(foilLength):
    out= tubeDiameter;
    while(foilLength>0):
        foilLength-= out*math.pi/2;
        out+= foilThickness;
    return out;

#spiral pattern foil
#integrate over previous problem => better preformance
#this model is more mathematically acurate, 
#however doesn't give the numbers you're looking for
#each rotation arround the pole needs to have enough 
#length to get on top of itself to start the next loop
def foil_spiral(foilLength):
    a= foilThickness * math.pi;
    b= tubeDiameter * math.pi;
    c= - foilLength;
    rotations= (-b + math.sqrt(math.pow(b,2) - 4*a*c))/2/a;
    return rotations*2*foilThickness+tubeDiameter;
    


    
print(foil_circles(0));
print(foil_circles(50));
print(foil_circles(4321));
print(foil_circles(10000));
print(foil_spiral(0));
print(foil_spiral(50));
print(foil_spiral(4321));
print(foil_spiral(10000));