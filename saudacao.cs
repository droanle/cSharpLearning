using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Programa para fazer o calculo de Bhaskara:\n");
    
    int hora;
    string nome, sobrenome, saudacao, orientacao;
    int sexo;

    Console.Write("Entre com o seu nome: ");
    nome = Console.ReadLine();

    Console.Write("Entre com o seu sobrenome: ");
    sobrenome = Console.ReadLine();

    Console.Write("Entre com a hora: ");
    hora = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\n Coloque: \n     '1' para o sexo masculino; \n     '0' para o feminino; ");
    sexo = Convert.ToInt32(Console.ReadLine());

    if(hora>=17 && hora<=4){ saudacao = "Boa noite"; }
    else if(hora>=5 && hora<=11){ saudacao = "Boa dia"; }
    else{ saudacao = "Boa tarde"; }

    if(sexo == 1) {orientacao = "Sr.";}
    else {orientacao = "Sra.";}

    Console.WriteLine("\n " + saudacao + " " + orientacao + nome + " " + sobrenome +"!");
    
  }
}