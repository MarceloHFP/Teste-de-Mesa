using System;

public class Ambiente
{
    public static void Main(string[] args)
    {
        int tamanhoDaTabela;
        double valorInicial, valorFinal, taxaJuros, rendimentoTotal, rendimentoLiquido;

        Console.WriteLine("Informe o valor inicial: ");
        valorInicial = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a taxa de juros (utilize vírgula para casas decimais): ");
        taxaJuros = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o período em meses: ");
        tamanhoDaTabela = Convert.ToInt32(Console.ReadLine());

        rendimentoTotal = valorInicial;

        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("| Valor Inicial | Taxa de Juros | Mês | Valor Final | Rendimento Liquido | Rendimento Total |");
        Console.WriteLine("--------------------------------------------------------");

        for (int i = 0; i < tamanhoDaTabela; i++)
        {
            valorFinal = valorInicial * Math.Pow(1 + taxaJuros / 100, i);
            rendimentoLiquido = valorFinal - rendimentoTotal;
            rendimentoTotal += rendimentoLiquido;

            Console.WriteLine($"| {Math.Round(valorInicial, 0),13} | {Math.Round(taxaJuros, 2),14} | {i,3} | {Math.Round(valorFinal, 0),11} | {Math.Round(rendimentoLiquido, 0),18} | {Math.Round(rendimentoTotal, 0),15} |");
        }

        Console.WriteLine("--------------------------------------------------------");
    }
}

