
def doesBrickFit(brickX, brickY, brickZ, holeX, holeY):
    [brickX, brickY, brickZ]= sorted([brickX, brickY, brickZ]);
    [holeX, holeY]= sorted([holeX, holeY]);
    return (brickX <= holeX) and (brickY <= holeY);
    
