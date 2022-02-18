using System;

namespace AmariEsercizio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int contoparola = 0;
            string parola = "";
            while(parola != "fine")
            {
                Console.WriteLine("Inserisci una parola");
                parola = Console.ReadLine();
                char primalettera = parola[0];
                int lunghezza = parola.Length;
                char ultimalettera = parola[lunghezza - 1];
                if (ultimalettera == primalettera)
                {
                    contoparola++;
                }
            }
            Console.WriteLine("Il numero delle parole che iniziano e finiscono per la stessa lettera è di: "+ contoparola);
        }
    }
}
