using System;
using System.Runtime.CompilerServices;

public class Ambiente {

    public static void Main(string[] args) {
        int tamanhoDaTabela, cont = 1;
        double valorInicial, valorFinal, taxaJuros, rendimentoTotal, rendimentoLiquido, resgate, b;
        char a;

        Console.WriteLine("Passe o valor inicial: ");
        valorInicial = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a taxa de juros (utilize vírgula para casas decimais): ");
        taxaJuros = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("Passe periodo em Meses: ");
        tamanhoDaTabela = Convert.ToInt32(Console.ReadLine());

        rendimentoTotal = valorInicial;
        Console.WriteLine("|Calculo|Rendimento Do Mes| Rendimento Acumulado");
        Console.WriteLine(" ");

        double[] v1 = new double[tamanhoDaTabela];
        double[] v2 = new double[tamanhoDaTabela];
        double[] v3 = new double[tamanhoDaTabela];

        for(int i = 1; i<= tamanhoDaTabela; i++) {
            valorFinal = valorInicial * Math.Pow(1 + (taxaJuros/100.0), i);
            v1[i-1] = valorFinal;
            
            Console.Write("|" + Math.Round(valorFinal, 2) + "|");
            rendimentoLiquido =  valorFinal - valorInicial;
            v2[i-1] = rendimentoLiquido;
            rendimentoTotal = rendimentoTotal + rendimentoLiquido;
            v3[i-1] = rendimentoTotal;
            Console.Write(Math.Round(rendimentoLiquido, 2) + "|");
            Console.Write(Math.Round(rendimentoTotal, 2) + "|");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            
            do{
            Console.WriteLine("Deseja resgatar ?: ");
            a = Convert.ToChar(Console.ReadLine());
            
            if(a == 's' || a == 'S') {
                Console.WriteLine("Quanto ?: ");
                resgate = Convert.ToDouble(Console.ReadLine());
                b = rendimentoTotal - resgate;
                if(b < valorInicial) {
                    valorInicial = b;
                    rendimentoTotal = b;
                } else {
                    rendimentoTotal = rendimentoTotal - resgate;
                }
                cont++;
                break;
            } else if(a == 'n' || a == 'N') {
                cont++;
                break;
            }else {
                Console.WriteLine("Operador invalido");
                Console.WriteLine("Tente novamente: ");
            }
            }while(cont < tamanhoDaTabela);
            }
            
            Console.WriteLine(" ");
            Console.WriteLine("|Calculo|Rendimento Do Mes|Rendimento Acumulado|");
            Console.WriteLine(" ");
            for(int l = 0; l < tamanhoDaTabela; l++) {
                Console.Write("|" + Math.Round(v1[l], 2) + "|");
                Console.Write(Math.Round(v2[l], 2) + "|");
                Console.Write(Math.Round(v3[l], 2) + "|");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
        
        }
    }
}
