using System; 

class DesafioParOuImpar {
  public static void Main() {
    int tc, i, x;
    
    tc = int.Parse(Console.ReadLine());
    
    for ( i = 0; i < tc; i++) {
      x = int.Parse(Console.ReadLine());
      
      if (x == 0) Console.WriteLine("NULL");
      if (x != 0) {
        if (x > 0) {
          Console.WriteLine(x % 2 ==0 ? "EVEN POSITIVE" : "ODD POSITIVE");
        } else if (x < 0) {
          Console.WriteLine(x % 2 ==0 ? "EVEN NEGATIVE" : "ODD NEGATIVE");
        }
      }
    }
    Console.ReadLine();
  }
}