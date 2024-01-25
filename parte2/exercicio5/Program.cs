using System;
using System.Runtime.CompilerServices;

public class Ambiente {

    public static void Main(string[] args) {
        int quantidadeMeses;
        double valorInicial, valorFinal, taxaJuros;
       

        Console.WriteLine("Passe o valor final: ");
        valorFinal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Passe a quantidade de Meses: ");
        quantidadeMeses = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Informe a taxa de juros (utilize vírgula para casas decimais): ");
        taxaJuros = Convert.ToDouble(Console.ReadLine()); 

        valorInicial = valorFinal/ Math.Pow(1+taxaJuros/100, quantidadeMeses);

        Console.WriteLine(valorInicial);
    }
}
