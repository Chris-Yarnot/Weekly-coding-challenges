using System;
					
public class CSharpAnswers
{
	public static bool IsKnight(int[,] gameBoard, int x, int y){
		if((x<0) || (y<0) || (x>=8) || (y>=8)){
			return false;
		}
		return gameBoard[x,y] == 1;
	}
	public static bool CannotCapture(int[,] gameBoard){
		for(int x= 0; x<8; x++){
			for(int y= 0; y<8; y++){
				if(IsKnight(gameBoard, x, y)){
					if(IsKnight(gameBoard, x-2, y+1)){
						return false;
					}
					if(IsKnight(gameBoard, x-1, y+2)){
						return false;
					}
					if(IsKnight(gameBoard, x+1, y+2)){
						return false;
					}
					if(IsKnight(gameBoard, x+2, y+1)){
						return false;
					}
				}
			}	
		}
		
		return true;
	}
	public static void Main()
	{
		Console.WriteLine(CannotCapture(new int[,] {
			{ 0, 0, 0, 1, 0, 0, 0, 0 },
			{ 0, 0, 0, 0, 0, 0, 0, 0 },
			{ 0, 1, 0, 0, 0, 1, 0, 0 },
			{ 0, 0, 0, 0, 1, 0, 1, 0 },
			{ 0, 1, 0, 0, 0, 1, 0, 0 },
			{ 0, 0, 0, 0, 0, 0, 0, 0 },
			{ 0, 1, 0, 0, 0, 0, 0, 1 },
			{ 0, 0, 0, 0, 1, 0, 0, 0 }}));
		Console.WriteLine(CannotCapture(new int[,] {
			{1, 0, 1, 0, 1, 0, 1, 0},
			{0, 1, 0, 1, 0, 1, 0, 1},
			{1, 0, 1, 0, 1, 0, 1, 0},
			{0, 0, 0, 1, 0, 1, 0, 1},
			{1, 0, 0, 0, 1, 0, 1, 0},
			{0, 0, 0, 0, 0, 1, 0, 1},
			{1, 0, 1, 0, 1, 0, 1, 0},
			{1, 0, 0, 1, 0, 0, 0, 1}}));
	}
}