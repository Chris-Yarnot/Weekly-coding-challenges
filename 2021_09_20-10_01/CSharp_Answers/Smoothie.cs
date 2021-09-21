using System;

public class Smoothie
{
	Ingrediant[] ingrediants;
	public Smoothie(String[] ing){
		ingrediants= new Ingrediant[ing.Length];
		for(int i= 0; i < ing.Length; i++){
			ingrediants[i]= Ingrediant.GetByName(ing[i]);
		}
	}
	public String Ingrediants{
	get{
		String s= "{";
		foreach(Ingrediant i in ingrediants){
			s= s + "\""+ i.name + "\",";
		}
		return s.Substring(0, s.Length-1)+"}";
	}
	}
	public override String ToString(){
		return Ingrediants;
	}
	public String GetCost(){
		return ConvertCostToString(GetCostAsInt());
	}
	public String GetPrice() {
		return ConvertCostToString(GetPriceAsInt());
	}
	public String GetName(){
		String s= "";
		Ingrediant[] ing= (Ingrediant[])(ingrediants.Clone());
		Array.Sort(ing,(x,y) => String.Compare(x.name, y.name));
		foreach(Ingrediant i in ing){
			s= s + i.smoothieName + " ";
		}
		if(ing.Length == 1){
			return s + "Smoothie";
		}else{
			return s + "Blend";
		}
	}
	private int GetCostAsInt(){
		int cost= 0;
		foreach(Ingrediant i in ingrediants){
			cost+= i.price;
		}
		return cost;
	}
	private int GetPriceAsInt() {
		return (int)(GetCostAsInt() * 2.5 + 0.5);	
	}
	private static String ConvertCostToString(int cost) {
		return "$"+ (cost/100) + "." + (cost%100/10) + (cost%10);
	}
	
	public static void Main()
	{
		Smoothie s1 = new Smoothie(new string[] { "Banana" });
		Console.WriteLine(s1);
		Console.WriteLine(s1.GetCost());
		Console.WriteLine(s1.GetPrice());
		Console.WriteLine(s1.GetName());
		Smoothie s2= new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });
		Console.WriteLine(s2);
		Console.WriteLine(s2.GetCost());
		Console.WriteLine(s2.GetPrice());
		Console.WriteLine(s2.GetName());
		Smoothie s3= new Smoothie(new string[] { "Apple" });
		//Apple is the only fruit type that has an odd cent value to test rounding
		Console.WriteLine(s3);
		Console.WriteLine(s3.GetCost());
		Console.WriteLine(s3.GetPrice());
		Console.WriteLine(s3.GetName());
		
	}
}