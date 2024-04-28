using System;

class Program
{
    static void Main(string[] args)
    {
       
        var n = 43;
        var m = 21;
        var j = 0;
        var cem = 0;
        var avr = 1;
        for (int i=m; i<= n; i++)
        {
            if (i % 21 == 0)
            {
                j++;
                cem += i;
                avr = cem / j;
            }
        }

        
        Console.WriteLine(avr);
    }
}
