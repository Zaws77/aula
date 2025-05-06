using System;

class MainClass {
  public static void Main (string[] args) {
    double n1, n2, tt = 0;
    char op; 
    string msgerro = ""; 

    Console.WriteLine("Digite o 1º Valor:");
    if (!double.TryParse(Console.ReadLine(), out n1)) {
        Console.WriteLine("Valor inválido para o primeiro número.");
        return;
    }

    Console.WriteLine("Digite o 2º Valor:");
    if (!double.TryParse(Console.ReadLine(), out n2)) {
        Console.WriteLine("Valor inválido para o segundo número.");
        return;
    }

    Console.WriteLine("Digite:\n+ para adição\n- para subtração\n* para multiplicação\n/ para divisão");
    if (!char.TryParse(Console.ReadLine(), out op)) {
        Console.WriteLine("Operador inválido.");
        return;
    }

    switch (op) {
      case '+':
         Console.WriteLine("Adição"); 
         tt = n1 + n2; 
         break;
      case '-': 
         Console.WriteLine("Subtração"); 
         tt = n1 - n2; 
         break;
      case '*':
         Console.WriteLine("Multiplicação"); 
         tt = n1 * n2; 
         break;
      case '/': 
         Console.WriteLine("Divisão"); 
         if (n2 != 0) {
            tt = n1 / n2; 
         } else {
           msgerro = "Não dividirás por ZERO!"; 
         }
         break;
      default: 
         msgerro = "Operação inválida!"; 
         break;
    }

    if (msgerro == "") {
      Console.WriteLine("{0} {1} {2} = {3}", n1, op, n2, tt);
    } else {
      Console.WriteLine("ERRO!!\n\n{0}", msgerro);
    }
  }
}
