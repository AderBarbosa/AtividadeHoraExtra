using System;

class Program {
  public static void Main (string[] args) {
  string conver, conver1;
    Double hora, valor, horasex, extra, salario, i;

  Console.WriteLine("Informe o valor de uma hora trbalhada: ");
  conver = Console.ReadLine ();
  valor = Double.Parse(conver);
  Console.WriteLine("Total de horas trabalhadas: ");
  conver1 = Console.ReadLine ();
  hora = Double.Parse(conver1);
  if (hora > 160)
    {
  horasex = (hora - 160);
    extra = ((horasex * valor) * 1.5);
    salario = extra + (valor * 160);
    Console.WriteLine(" O total de horas extra é de " + horasex + " e o valor do salário total é de " + salario);
    }
    else
    {
      salario = (valor * 160);Console.WriteLine(" O funcionário não realizou nenhuma hora extra, portanto seu salário é de: " + salario);
    }
    }
  }
