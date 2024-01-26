using System;

public class Ambiente {

    public static void Main(string[] args) {
        int tamanhoDaTabela, cont = 1;
        double valorInicial, valorFinal, taxaJuros, rendimentoTotal, rendimentoLiquido, resgate, b, c, d;
        string a;

        Console.WriteLine("Passe o valor inicial: ");
        valorInicial = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a taxa de juros (utilize vírgula para casas decimais): ");
        taxaJuros = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("Passe periodo em Meses: ");
        tamanhoDaTabela = Convert.ToInt32(Console.ReadLine());

        c = valorInicial;
        rendimentoTotal = valorInicial;

        // Cabeçalho da tabela
        Console.WriteLine("+---------------+---------+------------------+---------------------+");
        Console.WriteLine("| Valor Inicial | Cálculo  | Rendimento do Mês | Rendimento Acumulado |");
        Console.WriteLine("+---------------+---------+------------------+---------------------+");

        double[] vetorFinal = new double[tamanhoDaTabela];
        double[] vetorLiquido = new double[tamanhoDaTabela];
        double[] vetorTotal = new double[tamanhoDaTabela];

        for(int i = 1; i <= tamanhoDaTabela; i++) {
            valorFinal = valorInicial * Math.Pow(1 + (taxaJuros/100.0), i);
            vetorFinal[i-1] = valorFinal;
            
            rendimentoLiquido =  valorFinal - valorInicial;
            vetorLiquido[i-1] = rendimentoLiquido;
            rendimentoTotal += rendimentoLiquido;
            vetorTotal[i-1] = rendimentoTotal;

            // Linha da tabela
            Console.WriteLine($"| {Math.Round(valorInicial, 2),-13} | {Math.Round(valorFinal, 2),-8} | {Math.Round(rendimentoLiquido, 2),-16} | {Math.Round(rendimentoTotal, 2),-19} |");

            if(valorInicial < c) {
                valorInicial += rendimentoLiquido;
                if(valorInicial > c) {
                    d = valorInicial - c;
                    valorInicial -= d;
                }
            }

            do {
                Console.WriteLine("Deseja resgatar? (S/N): ");
                a = Convert.ToString(Console.ReadLine());
                a = a.ToUpper();
                
                if(a == "S" || a == "SIM") {
                    Console.WriteLine("Quanto? ");
                    resgate = Convert.ToDouble(Console.ReadLine());
                    b = rendimentoTotal - resgate;
                    if(b < valorInicial) {
                        valorInicial = b;
                        rendimentoTotal = b;
                    } else {
                        rendimentoTotal -= resgate;
                    }
                    cont++;
                    break;
                } else if(a == "N" || a == "NAO") {
                    cont++;
                    break;
                } else {
                    Console.WriteLine("Operador inválido");
                    Console.WriteLine("Tente novamente: ");
                }
            } while(cont < tamanhoDaTabela);
        }
        
        // Rodapé da tabela
        Console.WriteLine("+---------------+---------+------------------+---------------------+");
        Console.WriteLine(" ");
       Console.WriteLine("+---------------+---------+------------------+---------------------+");
        Console.WriteLine("| Valor Inicial | Cálculo  | Rendimento do Mês | Rendimento Acumulado |");
        Console.WriteLine("+---------------+---------+------------------+---------------------+");
        for(int l = 0; l < tamanhoDaTabela; l++) {
                Console.WriteLine($"| {Math.Round(valorInicial, 2),-13} | {Math.Round(vetorFinal[l], 2),-8} | {Math.Round(vetorLiquido[l], 2),-16} | {Math.Round(vetorTotal[l], 2),-19} |");
    }
    Console.WriteLine("+---------------+---------+------------------+---------------------+");
}
}


