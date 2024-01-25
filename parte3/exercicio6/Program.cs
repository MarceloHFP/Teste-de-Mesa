using System;

public class Ambiente {

    public static void Main(string[] args) {

        double dias;
        double taxaJuros, quantidadeMeses, valorInicial, valorFinal, b, c;
        string a;

        Console.WriteLine("Passe o investimento inicial: ");
        valorInicial = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a taxa de juros (utilize vírgula para casas decimais): ");
        taxaJuros = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Passe a quantidade de meses: ");
        quantidadeMeses = Convert.ToDouble(Console.ReadLine());

        
        a = Convert.ToString(Console.ReadLine());

        if(a == "s" || a == "S" || a == "Sim") {
            Console.WriteLine("quantos ?: ");
            dias = Convert.ToInt32(Console.ReadLine());
            valorFinal = valorInicial* Math.Pow(1+taxaJuros/100, quantidadeMeses+dias/30);
        }else {
            valorFinal = valorInicial* Math.Pow(1+taxaJuros/100, quantidadeMeses);
        }
        Console.WriteLine(valorFinal);
    }
}
