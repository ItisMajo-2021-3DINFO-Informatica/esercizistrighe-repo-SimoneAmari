using System;

namespace AmariEsercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quante parole vuoi analizzare?");
            int cont = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            int mediaminore = 0, mediamaggiore = 0;
            int contmin = 0, contmag = 0;

            while (i < cont)
            {
                Console.WriteLine("Inserisci la parola:");
                string parola = Console.ReadLine();

                int lunghezza = parola.Length;


                if (lunghezza <= 8)
                {
                    contmin++;
                    mediaminore = mediaminore + lunghezza;
                }
                else
                {
                    contmag++;
                    mediamaggiore = mediamaggiore + lunghezza;
                }

                i++;
            }
            mediaminore = mediaminore / contmin;
            mediamaggiore = mediamaggiore / contmag;
            
            Console.WriteLine("La media delle parole minori di 8 è di: " + mediaminore);
            Console.WriteLine("La media delle parole maggiori di 8 è di: " + mediamaggiore);
        }
    }
}
