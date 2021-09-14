public class Java_Answers {
	public static String rot13(String s){
        String output= "";
        for(int i= 0; i<s.length(); i++){
            char c= s.charAt(i);
            if((c>='a' && c<='m') || (c>='A' && c<='M')){
                c+= 13;
            }else if((c>='n' && c<='z') || (c>='N' && c<='Z')){
                c-= 13;
            }
            output= output + c;
        }
        return output;
    }
	
	public static String digits= "0123456789abcdefghijklmnopqrstuvwxyz";
	public static int base= 8;
	public static String changeBase(int i){
		if(i < 0){
			return "-"+changeBase(-i);
		}
		String output= "";
		
		do{
			output= digits.charAt(i%base) + output;
			i /= base;
		}while(i != 0);
		return output;
	}
    public static void main(String args[]) {
      System.out.println(rot13("test"));
      System.out.println(changeBase(42));
    }
}