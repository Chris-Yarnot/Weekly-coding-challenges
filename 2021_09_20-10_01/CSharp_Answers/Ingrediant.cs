public class Ingrediant{
	public String name;
	public int price;
	public String smoothieName;
	public Ingrediant(String n, int p){
		name= n;
		price= p;
		smoothieName= n.Replace("berries","berry"); 
	}
	private static Ingrediant[] ingrediants;
	public static Ingrediant[] GetList(){
		if(ingrediants != null){
			return ingrediants;
		}
		ingrediants= new Ingrediant[]{
			new Ingrediant("Strawberries", 150),
			new Ingrediant("Banana",       050),
			new Ingrediant("Mango",        250),
			new Ingrediant("Blueberries",  100),
			new Ingrediant("Raspberries",  100),
			new Ingrediant("Apple",        175),
			new Ingrediant("Pineapple",    350)
		};
		return ingrediants;
	}
	public static Ingrediant GetByName(String name){
		foreach(Ingrediant i in GetList()){
			if(i.name.Equals(name,StringComparison.OrdinalIgnoreCase) 
					|| i.smoothieName.Equals(name,StringComparison.OrdinalIgnoreCase)){
				return i;	
			}
		}
		return null;
	}
	public override String ToString(){
		return name;
	}
}