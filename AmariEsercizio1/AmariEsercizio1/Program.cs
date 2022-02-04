using System;

namespace AmariEsercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quante parole vuoi analizzare?");
            int cont = Convert.ToInt32(Console.ReadLine());

            int vocali = 0;
            int consonanti = 0;

            int i = 0;
            while (i < cont)
            {
                Console.WriteLine("Inserisci la parola:");
                string parola = Console.ReadLine();

                char lettera = parola[0];

                if (lettera == 'a')
                {
                    vocali++;
                }
                else if (lettera == 'e')
                {
                    vocali++;
                }
                else if (lettera == 'i')
                {
                    vocali++;
                }
                else if (lettera == 'o')
                {
                    vocali++;
                }
                else if (lettera == 'u')
                {
                    vocali++;
                }
                else
                {
                    consonanti++;
                }
                i++;
            }
            Console.WriteLine("Il numero delle consonanti è"+ consonanti);
            Console.WriteLine("Il numero delle vocali è" + vocali);
        }
    }
}
