using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denombrement_lettres
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] tableauAlpha = new char[26];
            string texte;
            int[] tabfrequences = new int[26];
            int compteurlettre;
            bool taille = false;
            do
            {
                Console.WriteLine("Veuillez entrer un texte d'au moins 120 caractères!");
                texte = (Console.ReadLine()).ToLower();
            } while (texte.Length <= 12);


            texte = filtreaccent(texte);
            char lettre = 'a';
            for (int i = 0; i < tableauAlpha.Length; i++)
            {
                tableauAlpha[i] = lettre;
                lettre++;

            }
            for (int i = 0; i < tabfrequences.Length; i++)
            {
                tabfrequences[i] = 0;
            }

            //C'est là que l'on s'amuse (signé jean).


            //for (int i = 0; i < texte.Length; i++)
            //{
            //    char temp = texte[i];
            //    for (int j = 0; j < tableauAlpha.Length; j++)
            //    {
            //        if (temp.CompareTo(tableauAlpha[j]) == 0)
            //        {
            //            tabfrequences[j]++;
            //        }
            //    }


            //}
            for (int i = 0; i < texte.Length; i++)
            {
                if (texte[i] >= 97 || texte[i] <= 122)
                {
                    tabfrequences[texte[i] - 97]++;
                }

            }
           for (int i = 0; i < tableauAlpha.Length; i++)
            {
                if (tabfrequences[i] != 0)
                {
                    Console.WriteLine("la lettre " + tableauAlpha[i] + " est presente : " + tabfrequences[i] + " .");
                }
            }

            Console.ReadKey();

        }
        static public string filtreaccent(string _Phrase)
        {
            _Phrase = _Phrase.Replace(" ", string.Empty);
            _Phrase = _Phrase.Replace("è", "e");
            _Phrase = _Phrase.Replace("é", "e");
            _Phrase = _Phrase.Replace("ê", "e");
            _Phrase = _Phrase.Replace("ë", "e");
            _Phrase = _Phrase.Replace("à", "a");
            _Phrase = _Phrase.Replace("ù", "u");
            _Phrase = _Phrase.Replace("î", "i");
            _Phrase = _Phrase.Replace("ô", "o");
            _Phrase = _Phrase.Replace("œ", "oe");
            _Phrase = _Phrase.Replace("â", "a");
            _Phrase = _Phrase.Replace("ï", "i");


            return _Phrase;

        }
    }
}
