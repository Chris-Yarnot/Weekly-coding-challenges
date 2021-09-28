public class JavaAnswers {
    public static void main(String args[]) {
      int x=10;
      int y=25;
      //switching begins here
      x= x+y;
      y= x-y;
      x= x-y;
      //they are switched
      System.out.println("x= " + x);
      System.out.println("y= " + y);
    }
}