public class JavaAnswers {
    public static boolean validateCard(long cardNumber){
        int place= 1;
        int sum= (int)(cardNumber%10);
        for(cardNumber/= 10; cardNumber != 0; cardNumber /= 10){
            int digit= (int)(cardNumber%10);
            if(place%2 == 1){
                digit= digit*2;
                digit= digit%10 + digit/10;
            }
            place++;
            sum+= digit;
        }
        return (place >= 14) && (place <= 19) && ((sum)%10 == 0);
    }
    public static void main(String args[]) {
        System.out.println(validateCard(1234567890123456L));
        System.out.println(validateCard(1234567890123452L));
    }
}