using System;
using System.Runtime.CompilerServices;

public class Ambiente {

    public static void Main(string[] args) {
        int periodoMes;
        double valorInicial, valorFinal, taxaJuros, a, b;

        Console.WriteLine("Passe o valor inicial: ");
        valorInicial = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a taxa de juros (utilize vírgula para casas decimais): ");
        taxaJuros = Convert.ToDouble(Console.ReadLine()); 
        
        Console.WriteLine("Passe periodo em Anos: ");
        periodoMes = Convert.ToInt32(Console.ReadLine());

        a = 1 + (taxaJuros/100.0);
        b = Math.Pow(a, periodoMes*12);
        valorFinal = valorInicial * b;

        Console.WriteLine("o rendimento é " + Math.Round(valorFinal-valorInicial, 2));
    }
}