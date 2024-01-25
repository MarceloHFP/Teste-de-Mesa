using System;

public class Teste2
{
    public static void Main(string[] args)
    {
        int a = 2;
        int[] v = new int[6];

        while(a<6){
            v[a] = 10 * a;
            Console.WriteLine(v[a]);
            a++;
        }
    }
}