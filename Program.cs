using System;
using System.Diagnostics;

namespace Lab02_RecursivoFibonacci;
class Program
{
    static void Main(string[] args)
    {
        Stopwatch time_recursividad = new Stopwatch();
        Stopwatch time_iterativo = new Stopwatch();

        int n;
        
        do {

            Console.WriteLine("Introduzca el número de términos: ");
            n = int.Parse(Console.ReadLine());

        }while(n <= 1);

        // Metodo recursivo 

        Console.WriteLine("Serie números de fibonnacci recursivo: ");
        
        time_recursividad.Start();

        for (int i = 0; i < n; i++)
        {
            Console.Write("  " + FibonacciRecursivo(i));
        }
        Console.WriteLine();
        Console.WriteLine("\n"+"*** Time spent in the recursive method: "+ time_recursividad.Elapsed.ToString() + " ***");
        time_recursividad.Stop();
        

        // Metodo iterativo

        Console.WriteLine();
        Console.WriteLine("Serie números de fibonnacci iterativo: ");
        
        time_iterativo.Start();

        FibonacciIterativo(n);
        Console.WriteLine("\n"+"*** Time spent in the iterative method: "+ time_recursividad.Elapsed.ToString()+ " ***");
        time_iterativo.Stop();
        Console.ReadKey();

    }

    static long FibonacciRecursivo(int n){
        if(n < 2) 
        {
            return n;
        }
        else 
        {
            return FibonacciRecursivo(n-2) + FibonacciRecursivo(n-1);
        }
    }

    static void FibonacciIterativo(int n){
        int ant1 = 0, ant2 = 1;
        int actual = 0;
        for (int i=1; i<=n; i++) { 
            Console.Write("  " + actual);
            actual = ant1 + ant2; 
            ant2 = ant1; 
            ant1 = actual; 
	    }
            Console.WriteLine();
            Console.WriteLine();
    }
}
