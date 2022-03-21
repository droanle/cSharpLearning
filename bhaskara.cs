using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Programa para fazer o calculo de Bhaskara:\n");
    double a=0, b=0, c=0, delta=0, x1=0, x2=0;

    Console.Write("Entre com o valor de A: ");
    a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Entre com o valor de B: ");
    b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Entre com o valor de C: ");
    c = Convert.ToDouble(Console.ReadLine());

    delta = (b*b) - (4*a*c);
    
    if(delta <= 0){
      Console.WriteLine ("Impossivel prosseguir!");
    } else {
      x1 = ((-b) + Math.Sqrt(delta))/(2*a);
      x2 = ((-b) - Math.Sqrt(delta))/(2*a);

      Console.WriteLine("\nResultado: ");
      Console.WriteLine("X1 = " + x1);
      Console.WriteLine("X2 = " + x2);
    }

    
  }
}