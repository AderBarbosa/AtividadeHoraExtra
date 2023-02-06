using System;

class Program {
  public static void Main (string[] args) {
  string conver, conver1, convert2;
    Double hora, valor, extra, salario, salarioat;

  Console.WriteLine("Informe seu salário bruto: ");  
  convert2 = Console.ReadLine ();
  salario = Double.Parse(convert2);
  Console.WriteLine("Informe o valor de uma hora trbalhada: ");
  conver = Console.ReadLine ();
  valor = Double.Parse(conver);
  Console.WriteLine("Total de horas trabalhadas: ");
  conver1 = Console.ReadLine ();
  hora = Double.Parse(conver1);
  if (hora > 160)
    {
    hora = (hora - 160);
    extra = ((valor * hora) * 2);
    salarioat = (extra + salario);
    Console.WriteLine(" O total de horas extra trabalhadas é de " + extra + " e o valor do salário total é de " + salarioat);
    }
    else
    {
    Console.WriteLine(" O funcionário não realizou nenhuma hora extra, portanto seu salário é de: " + salario);
    }
    }
  }