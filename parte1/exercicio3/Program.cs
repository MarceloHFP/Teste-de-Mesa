using System;

public class Teste2
{
    public static void Main(string[] args)
    {
        int a = 7;
        int b = a - 6;
        int[] v = new int[7];

        while(b<a){
            v[b] = b+a;
            Console.WriteLine(v[b]);
            b += 2;
        }
    }
}