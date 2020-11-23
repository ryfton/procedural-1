using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recherche_lettre
{
    class Program
    {
        static void Main(string[] args)
        {
            string finchaine;
            string Phrase;
            char lettre;
            uint compteur=0; 
            bool trouve = false;
            do
            {
                Console.WriteLine("Veuillez saisir une  phrase  terminée par un point(.)...");
                 Phrase = Console.ReadLine().ToLower();

                 finchaine= Phrase.Substring(Phrase.Length - 1, 1);

            } while ( finchaine!=".");

            if (Phrase.Length == 1 && finchaine == ".")
            {
                Console.WriteLine("La chaine est vide !!");
            }
            else
            {
                Phrase = Phrase.Replace(" ", string.Empty);
                Phrase = Phrase.Replace("è", "e");
                Phrase = Phrase.Replace("é", "e");
                Phrase = Phrase.Replace("ê", "e");
                Phrase = Phrase.Replace("ë", "e");
                Phrase = Phrase.Replace("à", "a");
                Phrase = Phrase.Replace("ù", "u");
                Phrase = Phrase.Replace("î", "i");
                Phrase = Phrase.Replace("ô", "o");

                // Console.Clear();
                Console.WriteLine("Veuillez saisir une lettre  à  rechercher dans la  phrase!!");
                lettre =char.Parse( Console.ReadLine());

                for (int i = 0; i < Phrase.Length-1; i++)
                {

                    if (lettre.CompareTo(Phrase[i])==0)
                    {
                        trouve = true;
                        compteur++;

                    }

                }

                if (trouve==false)
                {
                    Console.WriteLine("La lettre n'est  pas présente  dans la phrase! ");
                }
                else
                {
                    Console.WriteLine("la lettre est présente : {0: #,###} fois dans la phrase!", compteur);
                }

            }


            Console.ReadKey();



        }
    }
}
