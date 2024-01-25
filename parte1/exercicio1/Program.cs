using System;

public class Programa
{
    public static void Main(string[] args)
    {
        int a = 10, b = 20;
        int c = (a+b) / 2;
        c = c-40;
        int[] v = new int[4];

        for(int i = 0; i<4; i++){

            if(i == 3) {
                v[i] = a+b+c;
            }
        }
        Console.WriteLine(v[3]);
    }
}
