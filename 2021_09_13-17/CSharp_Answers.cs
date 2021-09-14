using System;
					
public class CSharp_Answers
{
	public const String MULT= " x ";
	public const String POWR= "^";
	
	// allPowersForm==true will show 12 as "2^2 x 3^1"
		//shows powers even if they are 1
	// powerlessForm==true will show 12 as "2 x 2 x 3"
		//lists prime factors multiple times instead of with exponenents
	// both true will show powerlessForm
	// default (both false) will show 12 as "2^2 x 3"
		//shows powers only if they are more than 1
	public static String ExpressFactors(int x, bool allPowersForm= false, bool powerlessForm= false){
		if (x <= 1){
			if(allPowersForm && !powerlessForm){
				return x.ToString() + POWR + "1";	
			}
			return x.ToString();	
		}
		String factors= "";
		for(int i= 2; i*i<=x; i++){
			if(x%i == 0){
				int pow= 0;
				while(x%i == 0){
					pow++;
					if(powerlessForm){
						factors+= MULT  + i;
					}		
					x/= i;
				}
				if(!powerlessForm){
					factors+= MULT  + i;
					if(pow != 1 || allPowersForm){
						factors+= POWR + pow;;	
					}
				}
			}
		}
		if(x != 1 ){
			factors	+= MULT + x;
			if(allPowersForm && !powerlessForm){
				factors+= POWR + "1";	
			}
		}
		return factors.Substring(MULT.Length);
	}
	public static void Main()
	{
		//1
		Console.WriteLine(ExpressFactors(1));
		//2
		Console.WriteLine(ExpressFactors(2));
		//2^2
		Console.WriteLine(ExpressFactors(4));
		//2 x 5
		Console.WriteLine(ExpressFactors(10));
		//2^2 x 3 x 5
		Console.WriteLine(ExpressFactors(60));
		
		//3 x 31 x 53 (Random number from 1->10000)
		Console.WriteLine(ExpressFactors(4929));
		//2 x 19913 (large prime * 2)
		Console.WriteLine(ExpressFactors(39826));
		//3 x 37 x 379 (number with interesting factorization)
		Console.WriteLine(ExpressFactors(42069));
	}
}