using ClassiLampadina;
using System;

namespace TestLampadina
{
    class Program
    {
        static void Main(string[] args)
        {
            int risposta;
            Lampadina l = new Lampadina("SPENTA", 5);
            Console.WriteLine("Per eseguire dei click digita = 1");
            Console.WriteLine("Per controllare la lampadina digita = 2");
            risposta = int.Parse(Console.ReadLine());
            if (risposta == 1)
            {
                Console.WriteLine("Quanti click vuoi fare?");
                int n = int.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                        Console.WriteLine("l1 = " + l.Click());
                }
            }else if (risposta == 2)
            {
                Console.WriteLine($"La lampadina è {l.Descrizione()}");
            }
        }
    }
}
