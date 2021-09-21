public class Java_Answers {
    public static final String sizes= "KMGTPEZY";
    public static String actualMemorySize(String s){
        double d= 0.93 * Integer.parseInt(s.substring(0, s.length() - 2));
        char type= s.toUpperCase().charAt(s.length() - 2);
        int i= sizes.indexOf(type);
        if(d < 1){
            d*= 1024;
            i--;
            type= sizes.charAt(i);
        }
        if((i <= 1) || (d%1 == 0) ){
            return "" + ((int)(d+0.5)) + type + 'B';
        }
        return "" + d + type + 'B';
    }
    
    public static void main(String args[]) {
        System.out.println(actualMemorySize("32GB"));
        System.out.println(actualMemorySize("2GB"));
        
        System.out.println(actualMemorySize("1TB"));
        System.out.println(actualMemorySize("1GB"));
        System.out.println(actualMemorySize("512MB"));
    }
}